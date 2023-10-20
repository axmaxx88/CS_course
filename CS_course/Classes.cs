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
            Car ferrari = new Car(); //конструктор по умолчанию
            Car lamborgini = new Car("Hurracan", 580, 2, 347.0f); //кастомный конструктор
            
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
        public int Years = 4; 

        //конструктор с параметрами
        public Car(string name, int horsePower, int age, float maxSpeed)
        {
            Name = name;
            HorsePower = horsePower;
            MaxSpeed = maxSpeed;
        }

        //пустой конструктор со значениями по умолчанию
        public Car()
        {
            Name = "Ford";
            HorsePower = 500;
            Age = 1;
            MaxSpeed = 300;
        }

        //Методы класса 
        public void ShowTechicalPasport()
        {
            Console.WriteLine($"Name auto: {Name}\nHorse Power amount: {HorsePower}" + 
                             $"\nAge of car: {Age}\nMax Speed: {MaxSpeed} ")
        }

        public void BecomeOlder(int Years, int runAwayHorses)
        {
            Age += this.Years + Years;    //this - указываем на тот элемент, который есть в классе
            HorsePower -= runAwayHorses;
        }
    }
   
}
