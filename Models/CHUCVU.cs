using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTL.Models
{
    internal class CHUCVU
    {
        [Key]
        public long MACV { get; set; } // INT, PRIMARY KEY
        public string NAME { get; set; } // VARCHAR(50)
        public decimal LUONG { get; set; } // MONEY
        
        [InverseProperty("CHUCVU")]
        public virtual ICollection<NHANVIEN> NHANVIEN { get; set; }
    }
}
