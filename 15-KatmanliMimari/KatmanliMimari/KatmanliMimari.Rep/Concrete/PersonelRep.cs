using KatmanliMimari.Core;
using KatmanliMimari.Dl;
using KatmanliMimari.Ent;
using KatmanliMimari.Rep.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Rep.Concrete
{
    public class PersonelRep<T> : BaseRepository<Personel>, IPersonelRep where T : class
    {
        public PersonelRep(MyContext db) : base(db)
        {

        }
    }
}
