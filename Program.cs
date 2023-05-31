using System;

namespace Program
{
    class Car
    {
        private string name;
        private int maxSpeed;

        public Car(string name, int maxSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int MaxSpeed
        {
            get 
            {
                return maxSpeed;
            }

            set
            {
                maxSpeed = value;
            }
        }

        public void PrintCar()
        {
            Console.WriteLine($"The name of the car is {name}");
            Console.WriteLine($"Maximum speed - {maxSpeed}");
        }
    }

    class Program
    {
        public static Car InputCar(int numberCar)
        {
            string name;
            int maxSpeed;

            Console.Write($"Enter the {numberCar} car name: ");
            name = Console.ReadLine();

            Console.Write($"Enter the speed of the {numberCar} car: ");
            do
            {
                maxSpeed = Convert.ToInt32(Console.ReadLine());
            } while (maxSpeed < 0);

            Car car = new Car(name, maxSpeed);

            return car;
        }

        public static void Main()
        {
            Car[] cars = new Car[2];
            
            for (int i = 0; i < 2; i++)
            {
                cars[i] = InputCar(i + 1);
            }

            if (cars[0].MaxSpeed > cars[1].MaxSpeed)
            {
                Console.WriteLine($"The car named - {cars[0].Name} has the highest maximum speed - {cars[0].MaxSpeed} km/h.");
            }
            else if (cars[0].MaxSpeed < cars[1].MaxSpeed)
            {
                Console.WriteLine($"The car named - {cars[1].Name} has the highest maximum speed - {cars[1].MaxSpeed} km/h.");
            }
            else
            {
                Console.WriteLine($"Cars {cars[0].Name} and {cars[1].Name} have the same maximum speed - {cars[0].MaxSpeed} km/h.");
            }
        }
    }
}