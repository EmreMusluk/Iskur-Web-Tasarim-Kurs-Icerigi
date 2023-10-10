using KatmanliMimari.Dl;
using KatmanliMimari.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Uow
{
    public class Unit : IUnit
    {
        MyContext _db;
        public IPersonelRep _personelRep { get; private set; }
        public Unit(MyContext db, IPersonelRep personelRep)
        {
            _db = db;
            _personelRep = personelRep;
        }
        public void Commit()
        {
            _db.SaveChanges();
        }
    }
}
