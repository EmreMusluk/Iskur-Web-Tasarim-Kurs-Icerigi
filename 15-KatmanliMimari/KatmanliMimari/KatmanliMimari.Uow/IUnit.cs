using KatmanliMimari.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Uow
{
    public interface IUnit
    {
        public IPersonelRep _personelRep { get; }
        void Commit();
    }
}
