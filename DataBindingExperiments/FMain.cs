using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingExperiments
{
    public partial class FMain : Form
    {
        private BindingList<Person> _persons;
        private Person _selectedItem;
        private int _index;

        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            this._persons = new BindingList<Person>();
            lbPersons.DataSource = this._persons;
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var surname = tbSurname.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Name or Surname are empty.");
                return;
            }

            var person = new Person()
            {
                Name = name,
                Surname = surname,
                Birthdate = new DateOnly(dtpBirthDate.Value.Date.Year,
                    dtpBirthDate.Value.Date.Month,
                    dtpBirthDate.Value.Date.Day)
            };

            this._persons.Add(person);
        }

        private void lbPersons_DoubleClick(object sender, EventArgs e)
        {
            _selectedItem = lbPersons.SelectedItem as Person;
            //this._index = this._persons.IndexOf(_selectedItem);

            tbName.Text = _selectedItem.Name;
            tbSurname.Text = _selectedItem.Surname;
            dtpBirthDate.Value = new DateTime(
                _selectedItem.Birthdate.Year,
                _selectedItem.Birthdate.Month,
                _selectedItem.Birthdate.Day);
        }

        private void bnStore_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var surname = tbSurname.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Name or Surname are empty.");
                return;
            }

            _selectedItem.Name = name;
            _selectedItem.Surname = surname;
            _selectedItem.Birthdate = new DateOnly(dtpBirthDate.Value.Date.Year,
                dtpBirthDate.Value.Date.Month,
                dtpBirthDate.Value.Date.Day);

            //this._persons[_index] = _selectedItem;
        }
    }

    public class Person : INotifyPropertyChanged
    {
        private string _name;
        private string _surname;
        private DateOnly _birthDate;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public DateOnly Birthdate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
                OnPropertyChanged("Birthdate");
            }
        }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Birthdate.ToString("dd/MM/yyyy")})";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}