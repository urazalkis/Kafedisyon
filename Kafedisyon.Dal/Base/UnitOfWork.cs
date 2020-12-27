using Kafedisyon.Common.Message;
using Kafedisyon.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedisyon.Dal.Base
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
       
        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            if (context == null) return;
            _context = context;
        }
        private bool _disposedValue;

        public IRepository<T> Rep => new Repository<T>(_context);

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {

                var sqlEx = (SqlException)ex.InnerException?.InnerException;
                if(sqlEx==null)
                {
                    Messages.HataMesaji(ex.Message);
                    return false;
                }
                switch (sqlEx.Number)
                {
                    case 208:
                        Messages.HataMesaji("İşlem yapmak istediğiniz tablo,veri tabanında bulunamadı!");
                        break;
                    case 547:
                        Messages.HataMesaji("Seçilen kartın işlem görmüş hareketleri mevcut.Kart silinemez!");
                        break;
                    case 2601:
                    case 2627:
                        Messages.HataMesaji("Girmiş Olduğunuz id daha önceden kullanılmıştır!");
                        break;
                    case 4060:
                        Messages.HataMesaji("İşlem yapmak istediğiniz veri tabanı,sunucuda bulunamadı!");
                        break;
                    case 18456:
                        Messages.HataMesaji("Servere bağlanılmak istenilen kullanıcı adı veya şifre hatalı!");
                        break;
                    default:
                        Messages.HataMesaji(sqlEx.Message);
                        break;
   
                }
                return false;

            }
            catch(Exception ex)
            {
                Messages.HataMesaji(ex.Message);
                return false;
            }
            return true;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
         
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
