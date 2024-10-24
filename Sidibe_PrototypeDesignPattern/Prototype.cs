using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidibe_PrototypeDesignPattern
{
    public abstract class Prototype
    {
        public abstract Prototype CreateClone();

        public abstract string PrintCloneInformation();

    }
}
