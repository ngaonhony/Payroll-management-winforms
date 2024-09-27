using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTL.Models
{
    internal class KHENTHUONGKYLUAT
    {
        
        [Key]
        public long MAKHENTHUONGKILUAT { get; set; } // int, primary key

        [ForeignKey("NHANVIEN")]
        public long MANV { get; set; } // nvarchar(50), foreign key
        public virtual NHANVIEN NHANVIEN { get; set; } // navigation property
        public string THUONGPHAT { get; set; } // nvarchar(max)
        public string LYDO { get; set; } // nvarchar(max)
        public DateTime NGAYAPDUNG { get; set; } // datetime
        public decimal SOTIEN { get; set; } // decimal

    }
}
