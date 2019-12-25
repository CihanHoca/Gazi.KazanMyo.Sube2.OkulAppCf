using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OgrenciBL:IDisposable
    {
        OkulContext ctx = new OkulContext();

        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }

        public void OgrenciEkle(Ogrenci o)
        {
            ctx.Ogrenciler.Add(o);            
        }

        public int SaveChanges()
        {
            return ctx.SaveChanges();
        }



    }
}
