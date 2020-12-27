using Kafedisyon.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedisyon.Model.Entities
{
    [Table("Bolum_Tbl")]
    public class Bolum:BaseEntityDurum
    {
        public string BolumAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
