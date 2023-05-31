using System.ComponentModel.DataAnnotations;

namespace DatabaseExperimentsLib.Entities
{
    public class BookType
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Name { get; set; }

        public virtual ICollection<Book> BooksOfType { get; set; }
    }
}
