using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MazdaCarFactory : CarFactory
    {
        public override Car CreateCar(string model)
        {
            switch (model.ToLower())
            {
                case "mx5": return new MazdaMX5();
                case "6": return new Mazda6();
                default: throw new ArgumentException("Invalid model.", "model");
            }
        }
    }
}
