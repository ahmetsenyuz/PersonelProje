using PersonelProje.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProje//her seferinde PersonelContext db = new PersonelContext(); yazmamak için class.
                       //Tek bağlantı oluşturur. Öteki türlü her newlediğimizde yeni bağlantı oluşuyordu.
{
    public static class DbConnect
    {
        static PersonelContext db;
        public static PersonelContext GetConnection()
        {
            if (db == null)
            {
                PersonelContext db = new PersonelContext();
                return db;
            }
            else { return db; }
        }
    }
}
