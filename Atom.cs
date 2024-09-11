using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab_6_Syed_Hussain_30140466
{
    internal class Atom
    {
        public string Name 
        { 
            get; 
            set; 
        }
        public string Symbol 
        { 
            get; 
            set; 
        }
        public int Proton 
        { 
            get; 
            set; 
        }
        public int Neutron 
        { 
            get; 
            set; 
        }
        public double Weight 
        { 
            get; 
            set; 
        }

        public Atom() { 
        }

        public Atom(string name, int proton, int neutron, double weight, string symbol)
        {
            Name = name;
            Proton = proton;
            Neutron = neutron;
            Weight = weight;
            Symbol = symbol;
        }

        public static Atom Parse(string line)
        {
            string[] parts = line.Split(' ');
            if (parts.Length != 5)
            {
                throw new ArgumentException("Input string does not contain five parts.");
            }

            return new Atom
            {
                Name = parts[0],
                Proton = int.Parse(parts[1]),
                Neutron = int.Parse(parts[2]),
                Weight = double.Parse(parts[3]),
                Symbol = parts[4]
            };
        }

        public override string ToString()
        {
            return $"{Name} {Proton} {Neutron} {Weight} {Symbol}";
        }
    }
}

