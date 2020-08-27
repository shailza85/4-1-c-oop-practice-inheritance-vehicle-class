using System;

namespace c_oop_practice_car_class_shailza85
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Toyota = new Car()
            {
                Make = "Toyota",
                Model = "Camry",
                Color = "Red",
                MaxOccupancy = 3,
                FeulEfficiency = 5.5
            };

            Car Nissan = new Car()
            {
                Make = "Nissan",
                Model = "Corolla",
                Color = "Blue",
                MaxOccupancy = 5,
                FeulEfficiency = 8.5
            };

            Car Chevrolet = new Car()
            {
                Make = "Chevrolet",
                Model = "Cruze",
                Color = "Green",
                MaxOccupancy = 7,
                FeulEfficiency = 10.5
            };

            TestCar(Toyota);
            TestCar(Nissan);
            TestCar(Chevrolet);

        }

        public static void TestCar(Car cTest)
        {
            Console.WriteLine(cTest);
            cTest.Drive();
            Console.WriteLine(cTest);
            try
            {
                cTest.Drive(20);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(cTest);
        }
    }
}
