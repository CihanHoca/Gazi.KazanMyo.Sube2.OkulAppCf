using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sinif
    {
        public int SinifId { get; set; }
        public string SinifAd { get; set; }

        public ICollection<Ogrenci> SiniftakiOgrenciler { get; set; }

    }
}
