using Kafedisyon.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedisyon.Model.Entities
{
    [Table("Urun_Tbl")]
    public class Urun:BaseEntityDurum
    {
        public string UrunAdi { get; set; }
        public int Fiyat { get; set; }
        public long KategoriId { get; set; }    
        public Kategori Kategori { get; set; }
        public string Aciklama { get; set; }


    }
}
