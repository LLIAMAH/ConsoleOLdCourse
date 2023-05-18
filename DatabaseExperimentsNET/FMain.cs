using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseExperimentsNET
{
    public enum EnumDbColumn
    {
        Id = 0,
        Login = 1,
    }

    public partial class FMain : Form
    {
        private string _connectionString;
        private BindingList<DbRecord> _list;

        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            this._connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnection"].ConnectionString;

            this._list = new BindingList<DbRecord>();
            lbOutput.DataSource = this._list;
        }

        private void bnLoadData_Click(object sender, EventArgs e)
        {
            this._list.Clear();
            using (var connection = new SqlConnection(this._connectionString))
            {
                try
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = @"
                                SELECT p.Id as Id,
		                                p.Login as Login,
		                                p.FirstName as FirstName,
		                                p.MiddleName as MiddleName,
		                                p.LastName as LastName,
		                                p.BirthDate as BirthDate,
		                                c.Name as Country,
		                                cc.Name as City,
		                                a.Street as Street,
		                                a.HauseNr as HouseNr,
		                                a.ApartmentsNr as ApartmentsNr
                                  FROM [CourseDB].[dbo].[Persons] p
                                  INNER JOIN dbo.Addresses a ON p.Id = a.PersonId
                                  INNER JOIN dbo.CountryCities cc ON a.CityId = cc.Id
                                  INNER JOIN dbo.Countries c ON c.Id = cc.CountryId;
                        ";

                        // command.ExecuteNonQuery(); -- запрос на исполнение комныды, которая НЕ ВОЗВРАЩАЕТ данные
                        // command.ExecuteScalar(); -- запрос на исполнение с возвратом ОДНОГО (скалярного) значение
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var item = new DbRecord()
                                {
                                    //Convert.ToInt64(reader[0])
                                    //Convert.ToInt64(reader["Id"]),
                                    Id = Convert.ToInt64(reader[(int)EnumDbColumn.Id]), 
                                    Login = reader["Login"].ToString(),
                                    FirstName = reader["FirstName"].ToString(),
                                    MiddleName = reader["MiddleName"] == DBNull.Value
                                        ? string.Empty
                                        : reader["MiddleName"].ToString(),
                                    LastName = reader["LastName"] == DBNull.Value
                                        ? string.Empty
                                        : reader["LastName"].ToString(),
                                    BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                                    Country = reader["Country"].ToString(),
                                    City = reader["City"].ToString(),
                                    Street = reader["Street"] == DBNull.Value
                                        ? string.Empty
                                        : reader["Street"].ToString(),
                                    HouseNr = reader["HouseNr"].ToString(),
                                    ApartmentsNr = reader["ApartmentsNr"].ToString()
                                };
                                this._list.Add(item);
                            }
                        }
                    }
                }
                catch (SqlException exSql)
                {
                    MessageBox.Show(exSql.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }

    public class DbRecord
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNr { get; set; }
        public string ApartmentsNr { get; set; }

        public override string ToString()
        {
            return
                $"{Id}, {Login}, {FirstName}, {MiddleName}, {LastName}, {BirthDate}, {Country}, {City}, {Street}, {HouseNr}, {ApartmentsNr}";
        }
    }
}
