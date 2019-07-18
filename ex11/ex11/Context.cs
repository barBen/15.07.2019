using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    class Context
    {
        careTaker careTake = new careTaker();

        public void Save(MyObj obj)
        {
            careTake.AddMemento(new ObjectMemento(obj));
        }

        public void Undo(MyObj obj)
        {
            ObjectMemento lastMemo = careTake.GetLast();
            if (lastMemo != null)
            {
                obj.ObjState = lastMemo.getObj().ObjState;
            }
        }
    }
}
