using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTL.Models
{
  
        internal class NHANVIEN
    {
        [Key]
        public long MANV { get; set; } // BIGINT, PRIMARY KEY
        public string NAME { get; set; } // NVARCHAR(255)

        // Khóa ngoại tới PHONGBAN
        [ForeignKey("PHONGBAN")]
   
        public long MAPB { get; set; } // FOREIGN KEY REFERENCES PHONGBAN(MAPB)
        public virtual PHONGBAN PHONGBAN { get; set; }

        // Khóa ngoại tới CHUCVU  
        [ForeignKey("CHUCVU")]
      
        public long MACV { get; set; } // FOREIGN KEY REFERENCES CHUCVU(MACV)
        public virtual CHUCVU CHUCVU { get; set; }

        public string? THUMBNAIL { get; set; } // IMAGE
        public DateTime BIRTHDAY { get; set; } // DATETIME
        public string GENDER { get; set; } // TINYINT
        public string ADDRESS { get; set; } // VARCHAR(20)
        public DateTime NGAYVAOLAM { get; set; } // DATETIME
        public string PHONE { get; set; } // VARCHAR(20)
        [InverseProperty("NHANVIEN")]
        public virtual ICollection<KHENTHUONGKYLUAT> KHENTHUONGKILUAT { get; set; }
        [InverseProperty("NHANVIEN")]
        public virtual ICollection<CHAMCONG> CHAMCONG { get; set; }
    }
}
