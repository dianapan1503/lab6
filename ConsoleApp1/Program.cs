using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Unicorn> unicorns = new List<Unicorn>();
            unicorns.Add(new Unicorn { Name = "Bob", Health = 10, Agility = 7, Strength = 7 });
            unicorns.Add(new Unicorn { Name = "Rob", Health = 6, Agility = 9, Strength = 8 });
            foreach (Unicorn infou in unicorns)
            {
                infou.InfoMeth();
            }
            Console.Write("\n");
            foreach (Unicorn unicornall in unicorns)
            {
                unicornall.Attack(10);
                unicornall.Defend(2);
                break;
            }
            Console.ReadKey();
        }
    }
    interface ICharacter
    {
        string Name { get; set; }
        double Health { get; set; }
        double Agility { get; set; }
        double Strength { get; set; }
        void Attack(double distance);
        void Defend(double damage);

    }
    class Unicorn : ICharacter
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double Agility { get; set; }
        public double Strength { get; set; }
        public void InfoMeth()
        {
            Console.WriteLine($"Ім'я єдинорога - {Name}");
            Console.WriteLine($"Здоров'я - {Health}, Спритність -  {Agility}, Сила - {Strength}");
        }
        public void Attack(double distance)
        {
            Console.WriteLine($"Боб атакує Роба на дистанції {distance} метрів");
        }
        public void Defend(double damage)
        {
            Console.WriteLine($"Відбувається захист від атаки, {damage} удара");
        }
    }


}
