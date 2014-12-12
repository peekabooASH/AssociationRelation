using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelationAPP
{
    class Boy
    {
      
        public string BoyName { set; get; }
        Girl aGirl=new Girl();

        public Girl GetSetGirl
        {
            get { return aGirl; }
            set { aGirl = value; }
        }

        public string showName()
        {
            return aGirl.GirlName;
        }
    }
}
