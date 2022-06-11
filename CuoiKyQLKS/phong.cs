using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky221
{
    class phong
    {
        protected String category262;
        protected int price262;

        public phong(String category262, int price262)
        {
            this.category262 = category262;
            this.price262 = price262;
        }

        public String getcategory262()
        {
            return category262;
        }

        public void setcategory262(String category262)
        {
            this.category262 = category262;
        }

        public int getprice262()
        {
            return price262;
        }

        public void setprice262(int price262)
        {
            this.price262 = price262;
        }

    }
}
