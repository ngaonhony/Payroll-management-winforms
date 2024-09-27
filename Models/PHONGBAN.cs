using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTL.Models
{
    internal class PHONGBAN
    {
        [Key]
        public long MAPB { get; set; } // INT, PRIMARY KEY
        public string NAME { get; set; } // VARCHAR(50)
        [InverseProperty("PHONGBAN")]
        public virtual ICollection<NHANVIEN> NHANVIEN { get; set; }
    }
}
