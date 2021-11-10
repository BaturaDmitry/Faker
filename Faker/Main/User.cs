using System;

namespace Main
{
    public class User
    {
        public String name;
        public int age;
        public long test { get; set; }
        public float money = 10.5f;
        public  Dog[] dogs;
        public Profile profile;
    }

   public class Dog
    {
        private string name; 
        private User owner;
        private Dog(string name,User owner)
        {
            this.name = name;
            this.owner = owner;
        }


    }

   public class Profile
    {
        public string address;
        public Profile(string address)
        {
            this.address = address;
        }
        
    }
}