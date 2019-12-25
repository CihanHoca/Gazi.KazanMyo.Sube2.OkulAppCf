using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   // [Table("tblOgrenciler")]
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        //[Column(TypeName ="varchar")]
        //[MaxLength(50)]
        //[Required]
        public string Ad { get; set; }
        //[Column(TypeName = "varchar")]
        //[MaxLength(75)]
        //[Required]
        public string Soyad { get; set; }
        //[Column(TypeName = "varchar")]
        //[MaxLength(10)]
        //[Required]
        public string Numara { get; set; }

        public int SinifId { get; set; }

        public Sinif OgrencininSinifi { get; set; }
    }
}
