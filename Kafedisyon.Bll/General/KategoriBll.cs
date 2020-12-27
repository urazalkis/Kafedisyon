using Kafedisyon.Bll.Base;
using Kafedisyon.Data.Context;
using Kafedisyon.Model.Entities;
using Kafedisyon.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafedisyon.Bll.General
{
    public class KategoriBll : BaseBll<Kategori, KafedisyonContext>
    {
        public KategoriBll()
        {
        }

        public KategoriBll(Control ctrl) : base(ctrl)
        {
        }

     /*   public BaseEntity Single(Expression<Func<Kategori,bool>> filter)
        {
         
        }*/
    }
}
