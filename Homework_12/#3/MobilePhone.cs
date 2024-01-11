using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class MobilePhone<T> where T : MobileNetwork
    {
        private T network;
        private T Network 
        { 
            get 
            { 
                return this.network; 
            } 
            set 
            { 
                this.network = value; 
            } 
        }

        public MobilePhone(T network) 
        {
            this.network = network;
        }
    }
}
