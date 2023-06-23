using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDAL
{
    //Design Pattern :- Unit of work pattern
    public interface IUow
    {
        void Commit();
        void RollBack();
    }
}
