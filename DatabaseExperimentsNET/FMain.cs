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
using DatabaseExperimentsNET.Model;

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
            // dsfasdfasdf
            // TODO: This line of code loads data into the 'courseDBDataSet.CountryCities' table. You can move, or remove it, as needed.
            this.countryCitiesTableAdapter.Fill(this.courseDBDataSet.CountryCities);
            // TODO: This line of code loads data into the 'courseDBDataSet.Countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.courseDBDataSet.Countries);

            UpdateCitiesDataSource();
            this._connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnection"].ConnectionString;
            this._list = new BindingList<DbRecord>();
            dgvOutput.DataSource = this._list;
        }

        private void UpdateDataView()
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
                                    FirstName = reader["FirstName"] == DBNull.Value
                                        ? string.Empty
                                        : reader["FirstName"].ToString(),
                                    MiddleName = reader["MiddleName"] == DBNull.Value
                                        ? string.Empty
                                        : reader["MiddleName"].ToString(),
                                    LastName = reader["LastName"] == DBNull.Value
                                        ? string.Empty
                                        : reader["LastName"].ToString(),
                                    BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                                    Country = reader["Country"].ToString(),
                                    City = reader["City"].ToString(),
                                    Street = reader["Street"].ToString(),
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

        private void bnLoadData_Click(object sender, EventArgs e)
        {
            UpdateDataView();
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCitiesDataSource();
        }

        private void UpdateCitiesDataSource()
        {
            var selectedCountryId = Convert.ToInt64(cbCountry.SelectedValue);
            try
            {
                this.countryCitiesTableAdapter.FillBy(this.courseDBDataSet.CountryCities, selectedCountryId);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            var newRecord = new InputRecord
            {
                Login = tbLogin.Text,
                FirstName = tbFirstName.Text,
                MiddleName = tbMiddleName.Text,
                LastName = tbLastName.Text,
                BirthDate = dtpBirthDate.Value.Date,
                CountryId = Convert.ToInt64(cbCountry.SelectedValue),
                CityId = Convert.ToInt64(cbCity.SelectedValue),
                Street = tbStreet.Text,
                HouseNr = tbHouseNr.Text,
                ApartmentsNr = tbApartmentsNr.Text
            };

            if (!newRecord.IsValid())
            {
                MessageBox.Show("Data for new record are invalid - recheck and refill.");
                return;
            }

            using (var connection = new SqlConnection(this._connectionString))
            {
                connection.Open();
                var transaction = connection.BeginTransaction();

                try
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;

                        command.Parameters.Clear();
                        command.CommandText = $@"
                                INSERT INTO [dbo].[Persons]
                                       ([Login]
                                       ,[FirstName]
                                       ,[MiddleName]
                                       ,[LastName]
                                       ,[BirthDate])
                                VALUES
                                       (@Login, 
		                               @FirstName,
		                               @MiddleName,
		                               @LastName,
		                               @BirthDate)
                                ";
                        command.Parameters.Add(new SqlParameter("Login", newRecord.Login));
                        command.Parameters.Add(new SqlParameter("FirstName", newRecord.FirstName));
                        command.Parameters.Add(new SqlParameter("MiddleName", newRecord.MiddleName));
                        command.Parameters.Add(new SqlParameter("LastName", newRecord.LastName));
                        command.Parameters.Add(new SqlParameter("BirthDate", newRecord.BirthDate.ToString("s")));
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();
                        command.CommandText = "SELECT Id FROM Persons WHERE Login = @Login";
                        command.Parameters.Add(new SqlParameter("Login", newRecord.Login));
                        var personId = command.ExecuteScalar();

                        command.Parameters.Clear();
                        command.CommandText = @"
                                INSERT INTO [dbo].[Addresses]
                                       ([Street]
                                       ,[CityId]
                                       ,[HauseNr]
                                       ,[ApartmentsNr]
                                       ,[PersonId])
                                VALUES
                                       (@Street,
                                       @CityId,                                            
                                       @HouseNr,
                                       @ApartmentsNr,
                                       @PersonId)
                                ";
                        command.Parameters.Add(new SqlParameter("Street", newRecord.Street));
                        command.Parameters.Add(new SqlParameter("CityId", newRecord.CityId));
                        command.Parameters.Add(new SqlParameter("HouseNr", newRecord.HouseNr));
                        command.Parameters.Add(new SqlParameter("ApartmentsNr", newRecord.ApartmentsNr));
                        command.Parameters.Add(new SqlParameter("PersonId", personId));
                        command.ExecuteNonQuery();

                        transaction.Commit();
                    }
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            UpdateDataView();

            ClearInputs();
        }

        private void ClearInputs()
        {
            tbLogin.Clear();
            tbFirstName.Clear();
            tbMiddleName.Clear();
            tbLastName.Clear();
            tbStreet.Clear();
            tbHouseNr.Clear();
            tbApartmentsNr.Clear();
        }

        private void bnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }

    public class InputRecord
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public long CountryId { get; set; }
        public long CityId { get; set; }
        public string Street { get; set; }
        public string HouseNr { get; set; }
        public string ApartmentsNr { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Login))
                return false;

            if (string.IsNullOrEmpty(Street))
                return false;

            if (string.IsNullOrEmpty(HouseNr))
                return false;

            if (string.IsNullOrEmpty(ApartmentsNr))
                return false;

            return true;
        }
    }
}
