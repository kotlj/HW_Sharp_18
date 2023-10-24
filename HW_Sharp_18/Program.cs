using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film("TestName", "TestStudio", "TestGenre", 2, 2222);
            GC.Collect();
            List<string> list = new List<string>{"Someone", "what?"};
            Perfomancecs perf = new Perfomancecs("Perfom", "Theatre", "Ganre", 2.2, list);
            GC.Collect();
        }
    }
}
