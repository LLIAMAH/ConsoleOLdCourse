using System.Xml.Serialization;

namespace AppWinFormsCore.Classes
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    [Serializable]
    public class Person
    {
        [XmlElement("dataID")]
        public long Id { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        //[XmlAttribute("gender")]
        //public Gender Gender { get; set; }

        public override string ToString()
        {
            //return $"Id: {Id}, Name: {Name}, Gender: {Gender.ToString()}";
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
