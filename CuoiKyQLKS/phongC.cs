using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky221
{
    class phongC : phong
    {
        public phongC() : base("C", 100)
        {
        }
        public override String ToString()
        {
            return "Phong C{" +
                    "Loai phong ='" + category262 + '\'' +
                    ", Gia=" + price262 +
                    '}';
        }

    }
}
