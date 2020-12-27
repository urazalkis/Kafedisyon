using Kafedisyon.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedisyon.Model.Entities
{
    [Table("Masa_Tbl")]
    public class Masa:BaseEntityDurum
    {
        public string MasaAdi { get; set; }
        public long BolumId { get; set; }
        public Bolum Bolum { get; set; }
        public string Aciklama { get; set; }
    }
}
