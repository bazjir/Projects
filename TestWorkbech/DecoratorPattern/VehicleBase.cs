using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class VehicleBase
    {
        public abstract string Make { get; }
        public abstract string Model { get; }
        public abstract double HirePrice { get; }
        public abstract int HireLaps { get; }
    }

    public class Ferrari360 :  VehicleBase
    {

        public override string Make
        {
            get { return "Ferrari"; }
        }

        public override string Model
        {
            get { return "360"; }
        }

        public override double HirePrice
        {
            get { return 100; }
        }

        public override int HireLaps
        {
            get { return 10; }
        }
    }

    public abstract class VehicleDecoratorBase : VehicleBase
    {
        private VehicleBase _vehicle;

        public VehicleDecoratorBase(VehicleBase vehicle)
        {
              _vehicle = vehicle;
        }

        public override string Make
        {
            get { return _vehicle.Make; }
        }

        public override string Model
        {
            get { return _vehicle.Model; }
        }

        public override double HirePrice
        {
            get { return _vehicle.HirePrice; }
        }

        public override int HireLaps
        {
            get { return _vehicle.HireLaps; }
        }
    }


    public class SpecialOffer : VehicleDecoratorBase
    {

        public SpecialOffer(VehicleBase vehicle):base(vehicle)
        {

        }

        public int DiscountPercentage { get; set; }
        public int ExtraLaps { get; set; }

        public override double HirePrice
        {
            get 
            {
                double price = base.HirePrice;
                int percentage = 100 - DiscountPercentage;
                return Math.Round((price*percentage) / 100,2);
            }
        }

        public override int HireLaps
        {
            get 
            {
                return base.HireLaps + ExtraLaps;
            }
        }
    }

    class Hireable : VehicleDecoratorBase
    {

        public Hireable(VehicleBase vehicle):base(vehicle)
        {

        }

        public void Hire(string name)
        {
            Console.WriteLine("{0} {1} hired by {2} at a price of {3:c} for {4} laps."
                , Make, Model, name, HirePrice, HireLaps);
        }
        
    }


}
