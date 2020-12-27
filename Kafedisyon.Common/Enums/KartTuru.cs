using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedisyon.Common.Enums
{
    public enum KartTuru:byte
    {
    [Description("Kategori Kartı")]
    Kategori=1,
    [Description("Ürün Kartı")]
    Urun=2,
    [Description("Bölüm Kartı")]
    Bolum=3,
    [Description("Fiyat Kartı")]
    Fiyat=4,
    [Description("Masa Kartı")]
    Masa=5,
    }
       
}
