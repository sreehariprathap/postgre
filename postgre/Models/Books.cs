using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetandPostgresql.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        [ForeignKey("AuthorFK")]
        public int AuthorFK { get; set; }
        public Author Author { get; set; }

    }
}
