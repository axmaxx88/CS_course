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
            
        } 
    }
    
    class Car
    {
        public string Name;
        public int HorsePower;
        public int Age;
        public float MaxSpeed;
        private int _model;
    }
   
}
