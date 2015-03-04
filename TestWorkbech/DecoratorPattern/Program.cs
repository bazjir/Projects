using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// The decorator pattern is a design pattern that extends the functionality of individual objects by wrapping them with one or more decorator classes.
    /// These decorators can modify existing members and add new methods and properties at run-time.
    /// 
    /// http://www.blackwasp.co.uk/Decorator.aspx
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            // Basic vehicle
            Ferrari360 car = new Ferrari360();

            Console.WriteLine("Base price is {0:c} for {1} laps.", car.HirePrice, car.HireLaps);


            // Special offer
            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.ExtraLaps = 2;

            Console.WriteLine("Offer price is {0:c} for {1} laps.", offer.HirePrice, offer.HireLaps);

            // Hire for basic vehicle
            Hireable hire1 = new Hireable(car);
            hire1.Hire("Bob");

            // Hire for vehicle with special offer
            Hireable hire2 = new Hireable(offer);
            hire2.Hire("Bill");

            Console.ReadLine();
        }
    }
}
