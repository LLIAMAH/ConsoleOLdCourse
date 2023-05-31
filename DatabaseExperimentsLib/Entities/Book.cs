using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseExperimentsLib.Entities
{
    public class Book
    {
        [Key]
        public long Id { get; set; } // BookId

        [Required, MaxLength(256)]
        public string Title { get; set; }

        [ForeignKey("BookType")]
        public long BookTypeId { get; set; }
        [Required]
        public BookType BookType { get; set; }

        public virtual ICollection<Author> Author { get; set; }

        [ForeignKey("Publisher")]
        public long PublisherId { get; set; }
        [Required]
        public Publisher Publisher { get; set; }

        public int Year { get; set; }
    }
}
