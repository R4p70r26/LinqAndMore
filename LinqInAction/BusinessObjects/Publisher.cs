using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInAction.BusinessObjects
{
    class Publisher
    {
        public String Name { get; set; }
        //public Bitmap Logo { get; set; }
        public String WebSite { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
