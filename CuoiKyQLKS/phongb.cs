using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky221
{
    class phongb : phong
    {
        public phongb() : base("B", 300)
        {
        }
        public override String ToString()
        {
            return "Phong B{" +
                    "Loại phòng ='" + category262 + '\'' +
                    ", Giá =" + price262 +
                    '}';
        }

    }
}