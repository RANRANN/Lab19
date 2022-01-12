using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Computer
    {
        public int Num { get; set; }
        public string Brend { get; set; }
        public string Proc { get; set; }
        public int FrequencyProc { get; set; }
        public int RAM { get; set; }
        public int VolumeDisk { get; set; }
        public int VolumeVideCard { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> listComputer = new List<Computer>()
            {
                new Computer(){Num=1,Brend="MSI", Proc="Intel", FrequencyProc=2000, RAM=16000, VolumeDisk=102400, VolumeVideCard=1760, Price=50000, Quantity= 20},
                new Computer(){Num=2,Brend="Acer", Proc="Amd", FrequencyProc=3000, RAM=12000, VolumeDisk=102400, VolumeVideCard=1800, Price=60000, Quantity= 10},
                new Computer(){Num=3,Brend="Dell", Proc="Amd", FrequencyProc=4000, RAM=8000, VolumeDisk=204800, VolumeVideCard=2000, Price=70000, Quantity= 15},
                new Computer(){Num=4,Brend="Asus", Proc="Amd", FrequencyProc=5000, RAM=10000, VolumeDisk=307200, VolumeVideCard=2400, Price=80000, Quantity= 30},
                new Computer(){Num=5,Brend="Lenovo", Proc="Intel", FrequencyProc=6000, RAM=16000, VolumeDisk=102400, VolumeVideCard=3000, Price=55000, Quantity= 5},
                new Computer(){Num=6,Brend="Dell", Proc="Intel", FrequencyProc=2000, RAM=6000, VolumeDisk=307200, VolumeVideCard=1560, Price=75000, Quantity= 2},
                new Computer(){Num=7,Brend="Dell", Proc="Intel", FrequencyProc=8000, RAM=24000, VolumeDisk=405600, VolumeVideCard=2200, Price=100000, Quantity= 3},
            };
            //Console.WriteLine("Название процессора");
            //string proc = Console.ReadLine();
            //List<Computer> listproc = listComputer.Where(x => x.Proc == proc).ToList();
            //Print(listproc);

            //Console.WriteLine("Объём оперативной памяти");
            //int ram = Convert.ToInt32(Console.ReadLine());
            //List<Computer> listram = listComputer.Where(x => x.RAM >= ram).ToList();
            //Print(listram);

            //List<Computer> listprice = listComputer.OrderBy(x => x.Price).ToList();
            //Print(listprice);

            IEnumerable<IGrouping<string, Computer>> listproc2 = listComputer.GroupBy(x => x.Proc);
            foreach (IGrouping<string, Computer> p in listproc2)
            {
                Console.WriteLine(p.Key);
                foreach (Computer c in p)
                {
                    Console.WriteLine($"{c.Num} {c.Brend} {c.Proc} {c.FrequencyProc} {c.RAM} {c.VolumeDisk} {c.VolumeVideCard} {c.Price} {c.Quantity}");
                }
            };
            Console.WriteLine();
            Console.ReadKey();

            Computer computer = listComputer.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer.Num} {computer.Brend} {computer.Proc} {computer.FrequencyProc} {computer.RAM} {computer.VolumeDisk} {computer.VolumeVideCard} {computer.Price} {computer.Quantity}");
            Console.WriteLine();
            Console.ReadKey();

            Computer computer1 = listComputer.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer1.Num} {computer1.Brend} {computer1.Proc} {computer1.FrequencyProc} {computer1.RAM} {computer1.VolumeDisk} {computer1.VolumeVideCard} {computer1.Price} {computer1.Quantity}");
            Console.WriteLine();
            Console.ReadKey();

            if (listComputer.Any(x => x.Quantity >= 30))
            {
                Console.WriteLine("Есть");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.ReadKey();
        }
        static void Print(List<Computer> listComputer)
        {
            foreach (Computer c in listComputer)
            {
                Console.WriteLine($"{c.Num} {c.Brend} {c.Proc} {c.FrequencyProc} {c.RAM} {c.VolumeDisk} {c.VolumeVideCard} {c.Price} {c.Quantity}");
            }
            Console.WriteLine();
        }
    }
}
