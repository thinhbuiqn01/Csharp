using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky221
{
    class nguoi
    {
        private String name262;
        private int age262;
        private String passport262;
        private phong room262;
        private int numberRent262;

        public nguoi(String name262, int age262, String passport262, phong room262, int numberRent262)
        {
            this.name262 = name262;
            this.age262 = age262;
            this.passport262 = passport262;
            this.numberRent262 = numberRent262;
            this.room262 = room262;
        }

        public int getnumberRent262()
        {
            return numberRent262;
        }

        public void setnumberRent262(int numberRent262)
        {
            this.numberRent262 = numberRent262;
        }

        public String getname262()
        {
            return name262;
        }

        public void setname262(String name262)
        {
            this.name262 = name262;
        }

        public int getage262()
        {
            return age262;
        }

        public void setage262(int age262)
        {
            this.age262 = age262;
        }

        public String getpassport262()
        {
            return passport262;
        }

        public void setpassport262(String passport262)
        {
            this.passport262 = passport262;
        }

        public phong getroom262()
        {
            return room262;
        }

        public void setroom262(phong room262)
        {
            this.room262 = room262;
        }

        public override String ToString()
        {
            return "Nguoi:{" +
                    "Họ tên='" + name262 + '\'' +
                    ", Tuổi=" + age262 +
                    ", CMND='" + passport262 + '\'' + room262.ToString() +
                    '}';
        }

    }
}
