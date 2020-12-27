using Kafedisyon.Model.Entities;
using Kafedisyon.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedisyon.Model.DataTransferObjects
{
  public class UrunDto_Single:Urun
    {
        public string KategoriAdi { get; set; }
    }
    public class UrunDto_List:BaseEntity
    {
        public string UrunAdi { get; set; }
        public string KategoriAdi { get; set; }
        public int Fiyat { get; set; }
        public string Aciklama { get; set; }

    }
}
