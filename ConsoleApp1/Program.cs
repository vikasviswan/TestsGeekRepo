using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public abstract class Vehicle
    {
        public abstract int MaxSpeed { get; set; }

        public virtual void Driver()
        {
            Console.WriteLine("Im driving a Vehicle");
        }
       
    }
    public  struct Car 
    {
        public  int MaxSpeed { get; set; }

      
    }

    public class Building
    {
        public Building(int year)
        {
            Console.WriteLine($"The building was built in {year}");
        }

        ~Building()
        {
            Console.WriteLine("The building is destroyed");
        }
    }
    public class House:Building,IDisposable
    {
        public House(int num, int year) : base(year)
        {
            Console.WriteLine($"The house has built in {num} bedrooms");
        }
        static House()
        {
            Console.WriteLine("That is a house");
        }

        ~House()
        {
            Console.WriteLine("The House is destroyed");
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~House() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

    public class Shape
    {
        public string GetName() { return "shape";  }
    }
    public class Ball: Shape
    {
        public new string GetName() { return "Ball"; }
    }
    public class Pet
    {
        public virtual string GetName() { return "pet"; }
    }
    public class Cat: Pet
    {
        public override string GetName() { return "Cat"; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var car = new Car { MaxSpeed = 300 };
            //car.Driver();
            Car a = null;
            
            Console.WriteLine(true);
           // using (House house1 = new House(4, 2010))
           // {

           // }

           //     //var house2 = new House(2, 2017);
           //     //int number =50 ;
           //     //changeNum(ref number);
           //     //Console.WriteLine($"Number is {number}");

           //     Pet pet = new Cat();
           //     Shape shape = new Ball();
           //// shape.GetName();
           // Console.WriteLine(pet.GetName());
           // Console.WriteLine(shape.GetName());

            Console.ReadLine();

        }

        public static void changeNum(ref int number)
        {
            number = 100;
        }
    }
}
