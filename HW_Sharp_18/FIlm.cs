using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_18
{
    internal class Film : IDisposable
    {
        public string Name { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public int Hours { get; set; }
        public int Year {  get; set; }
        public Film(string name, string studio, string genre, int hours, int year)
        {
            Name = name;
            Studio = studio;
            Genre = genre;
            Hours = hours;
            Year = year;
        }
        public void Dispose()
        {
            Console.WriteLine($"{Name} was Disposed;");
        }
        ~Film()
        {
            Console.WriteLine($"{Name} was deleted;");
        }
    }
}
