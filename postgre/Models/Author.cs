using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetandPostgresql.Models
{
    public class Author
    {

        public int AuthorID { get; set; }

        public string AuthorName { get; set; }
        [ForeignKey("AuthorFK")]
        public ICollection<Books> Book { get; set; }
    }
}
