using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExperimentsNET.Model
{
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
                $"{Id}, {Login}, {FirstName}, {MiddleName}, {LastName}, {BirthDate}, {Country}, {City}, {Street}-{HouseNr}, {ApartmentsNr}";
        }
    }
}
