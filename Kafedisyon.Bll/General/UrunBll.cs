using Kafedisyon.Bll.Base;
using Kafedisyon.Common.Enums;
using Kafedisyon.Data.Context;
using Kafedisyon.Model.DataTransferObjects;
using Kafedisyon.Model.Entities;
using Kafedisyon.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Kafedisyon.Bll.General
{
    public class UrunBll : BaseBll<Urun, KafedisyonContext>
    {
        public UrunBll()
        {
        }

        public UrunBll(Control ctrl) : base(ctrl)
        {
        }
        public BaseEntity Single(Expression<Func<Urun, bool>> filter)
        {
            return BaseSingle(filter, x => new UrunDto_Single
            {
                Id=x.Id,
                Kod=x.Kod,
                UrunAdi=x.UrunAdi,
                Fiyat=x.Fiyat,
                KategoriId=x.KategoriId,
                KategoriAdi=x.Kategori.KategoriAdi,
                Aciklama = x.Aciklama,
                Durum=x.Durum,
 
            });
        }

        public IEnumerable<BaseEntity> List(Expression<Func<Urun, bool>> filter)
        {
            return BaseList(filter, x => new UrunDto_List
            {
            Id = x.Id,
            Kod = x.Kod,
            UrunAdi=x.UrunAdi,
            Fiyat = x.Fiyat,
            KategoriAdi =x.Kategori.KategoriAdi,
            }).OrderBy(x=>x.Kod).ToList();
        }
        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
            
        }
        public bool Update(BaseEntity oldEntity,BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity,x=>x.Kod==currentEntity.Kod);
        }
        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Urun);
        }
    }
}
