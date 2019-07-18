using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    class ObjectMemento 
    {
        readonly MyObj myObj;

        public ObjectMemento(MyObj currObj)
        {
            this.myObj = currObj;
        }

        public MyObj getObj()
        {
            return this.myObj;
        }
    }
}
