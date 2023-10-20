using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Car ferrari = new Car();
            ferrari.Name = "F40";
            ferrari.HorsePower = 471;
            ferrari.Age = 30;
            ferrari.MaxSpeed = 317.0f;

            ferrari.ShowTechnicalPasport();
            ferrari.BecomeOlder(5, 50);
            
        } 
    }
    
    class Car
    {
        //public, private - модификатор доступа (если не указать, то установится по умолчанию private)
        //наименование private полей - _nameOfVariable
        //наименование public полей - NameOfVariable
        public string Name;
        int _horsePower;
        private int _age;
        public float MaxSpeed;
        private int _model;

        //Методы класса 
        public void ShowTechicalPasport()
        {
            Console.WriteLine($"Name auto: {Name}\nHorse Power amount: {HorsePower}" + 
                             $"\nAge of car: {Age}\nMax Speed: {MaxSpeed} ")
        }

        public void BecomeOlder(int years, int runAwayHorses)
        {
            Age += years;
            HorsePower -= runAwayHorses;
        }
    }
   
}
