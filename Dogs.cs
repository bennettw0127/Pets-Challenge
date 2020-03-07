using System;

namespace Pets
{
    class Dog:Pets
    {
        public Dog(string Name, string Owner, double Weight):base("Dog", Name, Owner, Weight)
        {
            name=Name;
            Owner=Owner;
            Weight=Weight;
        }
        public string bark (int count)
        {
            int sound;
            string bark= "";

            for (sound=0;sound<count;sound++)
            {
                bark +="bark!";
            }
            return bark;
        }
    }
}