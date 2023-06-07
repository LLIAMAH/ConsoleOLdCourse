using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DatabaseExperimentsLib.Entities
{
    [Index(nameof(Name), IsUnique = true)]
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
