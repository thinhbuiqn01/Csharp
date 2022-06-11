using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky221
{
    class khachsan
    {
        private List<nguoi> List;
        public khachsan()
        {
            this.List = new List<nguoi>();
        }
        public void add(nguoi n)
        {
            this.List.Add(n);
        }
        public Boolean delete(String passport)
        {
            var rs = List.FindAll((x) => { return x.getpassport262().Equals(passport); }).First();
            if (rs == null)
            {
                return false;
            }
            else
            {
                this.List.Remove(rs);
                return true;
            }
        }

        public int calculator(String passport262)
        {
            var rs = List.FindAll((x) => { return x.getpassport262().Equals(passport262); }).First();
            int tongtien = 0;
            if (rs == null)
            {
                return 0;
            }
            else
            {
                tongtien = rs.getroom262().getprice262() * rs.getnumberRent262();
            }
            return tongtien;
        }

        public void show()
        {
            foreach (var x in this.List)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}