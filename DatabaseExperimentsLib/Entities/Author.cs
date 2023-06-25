using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseExperimentsLib.Entities
{
    [Index(nameof(FirstName), nameof(LastName), IsUnique = true)]
    public class Author
    {
        [Key]
        public long Id { get; set; }

        [Required, MaxLength(128)]
        public string FirstName { get; set; }
        [MaxLength(128)]
        public string LastName { get; set; }

        public virtual ICollection<Book> AuthorBooks { get; set; }

        [NotMapped]
        public string FullName
        {
            get { return $"{this.FirstName} {this.LastName}"; }
        }
    }
}
