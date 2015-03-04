using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary> Template Method Design Pattern || Strategy Design Pattern
    /// The template method pattern is a design pattern that allows a group of interchangeable, similarly structured, multi-step algorithms to be defined.
    /// Each algorithm follows the same series of actions but provides a different implementation of the steps.
    /// 
    /// 1. The overall structure of the basic algorithm is defined in an abstract base class.
    /// This class may include some real functionality but often just defines the order in which the overridable steps will be executed.
    /// 
    /// 
    /// http://www.blackwasp.co.uk/TemplateMethod.aspx
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ScoringAlgorithm algoirthm;

            Console.WriteLine("Man ");
            algoirthm = new MensScoringAlgoritm();
            Console.WriteLine(algoirthm.GenerateScore(8,new TimeSpan(0,1,31)));


            Console.WriteLine("Woman ");
            algoirthm = new WomensScoringAlgorithm();
            Console.WriteLine(algoirthm.GenerateScore(9,new TimeSpan(0,1,49)));

            Console.ReadLine();
        }
    }
}
