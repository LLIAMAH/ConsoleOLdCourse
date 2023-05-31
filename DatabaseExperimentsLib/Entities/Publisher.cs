using System.ComponentModel.DataAnnotations;

namespace DatabaseExperimentsLib.Entities
{
    public class Publisher
    {
        [Key]
        public long Id { get; set; }

        [Required, MaxLength(256)]
        public string Name { get; set; }

        public virtual ICollection<Book> PublisherBooks { get; set; }
    }
}
