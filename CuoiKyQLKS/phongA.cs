using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky221
{
    class phongA : phong
    {
        public phongA() : base("A", 500)
        {
        }
        public override String ToString()
        {
            return "Phong A{" +
                    "Loại Phòng='" + category262 + '\'' +
                    ", Giá =" + price262 +
                    '}';
        }

    }
}
