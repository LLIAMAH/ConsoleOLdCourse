using System.ComponentModel.DataAnnotations;

namespace DatabaseExperimentsLib.Entities
{
    public class Author
    {
        [Key]
        public long Id { get; set; }

        [Required, MaxLength(128)]
        public string FirstName { get; set; }
        [MaxLength(128)]
        public string LastName { get; set; }

        public virtual ICollection<Book> AuthorBooks { get; set; }
    }
}
