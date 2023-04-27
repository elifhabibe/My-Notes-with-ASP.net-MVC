using MyEvernote.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SINGLETON PATTERN
namespace MyEvernote.DataAccessLayer.EntityFramwork
{
    public class RepositoryBase
    {
        private static DatabaseContext _db;//null değilse database bir kere oluşur ve static olan _db döner ver hep bunu kullanırız
        private static object _lockSync = new object();
        
        protected RepositoryBase()
        {

        }

        public static DatabaseContext CreateContext()
        {
            if(_db == null)
            {
                lock(_lockSync)
                {
                    if(_db==null)
                    {
                        _db = new DatabaseContext();
                    }
                }
            }
            return _db;
        }
    }
}
