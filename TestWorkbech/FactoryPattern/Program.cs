using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{

    /***
     * 
     * The factory method pattern is a design pattern that allows for the creation of objects 
     * without specifying the type of object that is to be created in code.
     * A factory class contains a method that allows determination of the created type at run-time.
     * 
     * 
     * 
     * Factory Design Pattern (Tasarım Şablonu) ile amaç, uygun nesneleri uygulamaya döndürmektir.
     * Şablonun temel işlevi, adından da belli olduğu gibi sınıfların örneklerini üretmektir.
     * Bu tanımlamayı biraz daha açarsak, bir sınıfdan ya da interfaceden türetilen n tane alt sınıf varsa, bu altsınıfların herbiri birbirinden farklı birtakım özel işlemleri gerçekleştirmek için geliştirilmiştir.
     * Fakat bu n tane altsınıfın herbiri, türetildiği üst sınıfın sağladığı methodları kalıtım ile devralır ya da interfacein sunduğu methodları uygulamak zorundadır.
     * Sonuçta bu altsınıflar, türetildiği üst sınıf ya da interfacein tasarlanış felsefesi ile alakalı işlemler gerçekleştirir. Factory tasarım şablonu ile amaçlanan, bu altsınıfları, sınıfların detayından bağımsız olarak uygulamaya döndürmektir.
     * 
     * 
     * resource: 
     * http://www.blackwasp.co.uk/FactoryMethod.aspx
     * http://www.javablog.org/78-factory-design-pattern
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            HyundaiCarFactory hCarFactory = new HyundaiCarFactory();

            Car i130 =  hCarFactory.CreateCar("i30");

            Console.WriteLine(i130.GetType());

            Console.Read();
        }
    }
}
