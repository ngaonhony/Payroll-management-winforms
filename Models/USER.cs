using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTL.Models
{
    internal class USER
    {
        [Key]
        public string USERNAME { get; set; }

        public string PASSWORD { get; set; }
    }
}
