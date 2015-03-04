using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 
    /// 
    /// 
    /// 
    /// Resource: http://www.blackwasp.co.uk/Singleton.aspx
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singletonPattern = Singleton.GetSingleton();
        }
    }
}
