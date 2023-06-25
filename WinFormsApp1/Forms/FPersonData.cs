using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    internal enum PersonMode
    {
        New = 0,
        Edit
    }

    public partial class FPersonData : Form
    {
        private PersonMode _mode;
        private Person _data;

        public FPersonData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstName = tbFirstName.Text;
            var lastName = tbLastName.Text;
            var birthDate = dtpBirthDate.Value.Date;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                return;

            switch (this._mode)
            {
                case PersonMode.Edit:
                {
                    _data.FirstName = firstName;
                    _data.LastName = lastName;
                    _data.BirthDate = new DateOnly(birthDate.Year, birthDate.Month, birthDate.Day);
                }
                    break;
                default:
                {
                    _data = new
                        Person
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            BirthDate = new DateOnly(birthDate.Year, birthDate.Month, birthDate.Day)
                        };
                }
                    break;
            }

            DialogResult = DialogResult.OK;
        }

        public Person GetData(long? maxId = null)
        {
            if (maxId != null)
                _data.Id = maxId.Value;

            return _data;
        }

        public void SetData(Person person)
        {
            this._mode = PersonMode.Edit;
            this._data = person;

            this.tbFirstName.Text = _data.FirstName;
            this.tbLastName.Text = _data.LastName;
            this.dtpBirthDate.Value = _data.BirthDate.ToDateTime(new TimeOnly(0, 0));
        }
    }
}
