using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
    class Room
    {
        protected string category;
        protected int price;
        public Room()
        {

        }

        public Room(string category, int price)
        {
            this.category = category;
            this.price = price;
        }

        public string getCategory()
        {
            return category;
        }

        public void setCategory(string category)
        {
            this.category = category;
        }

        public int getPrice()
        {
            return price;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }
        public virtual void display()
        {

        }
    }
    class RoomA : Room
    {
        public RoomA()
        {
            this.price = 500;
        }

        
        public override void display()
        {
            Console.WriteLine( "RoomA{" +
                    "category='" + category + '\'' +
                    ", price=" + price +
                    '}');
        }
    }
    class RoomB : Room
    {
        public RoomB()
        {
            this.price = 300;
        }


        public override void display()
        {
            Console.WriteLine("RoomB{" +
                    "category='" + category + '\'' +
                    ", price=" + price +
                    '}');
        }
    }
    class RoomC : Room
    {
        public RoomC()
        {
            this.price = 100;
        }


        public override void display()
        {
            Console.WriteLine("RoomC{" +
                    "category='" + category + '\'' +
                    ", price=" + price +
                    '}');
        }
    }
    class Person
    {
        private string name;
        private int age;
        private string passport;
        private Room room;
        private int numberRent;

        public Person(string name, int age, string passport, Room room, int numberRent)
        {
            this.name = name;
            this.age = age;
            this.passport = passport;
            this.numberRent = numberRent;
            this.room = room;
        }

        public int getNumberRent()
        {
            return numberRent;
        }

        public void setNumberRent(int numberRent)
        {
            this.numberRent = numberRent;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public string getPassport()
        {
            return passport;
        }

        public void setPassport(string passport)
        {
            this.passport = passport;
        }

        public Room getRoom()
        {
            return room;
        }

        public void setRoom(Room room)
        {
            this.room = room;
        }

        public override void display()
        {
            Console.WriteLine( "Person{" +"name='" + name + '\'' +
                    ", age=" + age +
                    ", passport='" + passport + '\'' + room.display() +
                    '}');
        }
    }
}
