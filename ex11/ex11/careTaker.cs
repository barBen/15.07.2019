using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    class careTaker
    {
        ObjectMemento momento = null;

        public void AddMemento(ObjectMemento memento)
        {
            this.momento = memento;
        }

        public ObjectMemento GetLast()
        {
            return this.momento;
        }
    }
}
