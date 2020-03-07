using System;

namespace Pets
{
    class Pets
    {
        public string type;
        
        public string name;
        
        public string owner;

        public double weight;

        public Pets(string Type, string Name, string Owner, double Weight)
        {
            type=Type;
            name=Name;
            owner=Owner;
            Weight=Weight;
        }
        public string getTag()
        {
            string tag="If lost call"+owner;
            return tag;
        }
    }
}