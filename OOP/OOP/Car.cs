using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public enum Color
    {
        Red,
        Green,
        Blue,
        Black

    }
    internal class Car
    {
        private readonly Color _color = default;
        private string _name = "audi";
        private string _brand = "au-1";
        private DateTime _year;
        //private int _speed;


        public static int price;
        // Default Construtor

        public Car()
        {
            Console.WriteLine($"{_name} has Created");
        }

        //Full constructor
        public Car(Color color, string name, string brand, DateTime year, int speed)
        {
            _color = color;
            _name = name;
            _brand = brand;
            _year = year;
            _speed = speed;
        }

        public void SetcarName(string name)
        {
            _name = name;
        }
        public string GetCarName()
        {
            return _name;
        }

        public Car(Color color, string name)
        {
            _color = color;
            _name = name;
        }

        public void Start()
        {
            Console.WriteLine($"{_name} has started");
        }

        public void Speed()
        {
            Console.WriteLine($"{_name} speed is {_speed} km/h");
        }

        public void CarDetails()
        {
            Console.WriteLine($"{_name} speed is {_speed} km/h, which color is {_color}. This car has manufactured{_year} years. Car Brand is {_brand}");
        }
    }
}
