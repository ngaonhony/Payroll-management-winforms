using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTL.Models
{
    internal class CHAMCONG
    {
       
        [Key]
        public long MACC { get; set; } // BIGINT, PRIMARY KEY

        // Khóa ngoại tới NHANVIEN
        [ForeignKey(nameof(NHANVIEN))]
        public long MANV { get; set; } // VARCHAR(50), FOREIGN KEY REFERENCES NHANVIEN(MANV)
        public virtual NHANVIEN NHANVIEN { get; set; }

        public int NGAYCONG { get; set; }
        public int NGHIHL { get; set; }
        public int THANG { get; set; }
        public int NAM { get; set; }
        public decimal THANHTIEN { get; set; } // MONEY


    }
}
