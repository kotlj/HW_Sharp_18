using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_18
{
    internal class Perfomancecs : IDisposable
    {
        public string Name { get; set; }
        public string Theater { get; set; }
        public string Ganre { get; set; }
        public double Hours { get; set; }
        public List<string> Actors { get; set; }
        public Perfomancecs(string name, string theater, string ganre, double hours, List<string> actors)
        {
            Name = name;
            Theater = theater;
            Ganre = ganre;
            Hours = hours;
            Actors = actors;
        }
        public void Dispose()
        {
            Console.WriteLine($"{Name} was disposed;");
        }
        ~Perfomancecs()
        {
            Console.WriteLine($"{Name} was deleted;");
        }
    }
}
