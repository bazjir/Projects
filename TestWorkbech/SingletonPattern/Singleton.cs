using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{


    /// <summary>
    /// 1. The constructor for the class is marked as private.
    /// This prevents any external classes from creating new instances.
    /// The class is also sealed to prevent inheritance, which could lead to subclassing that breaks the singleton rules.
    /// 
    /// WHEHN TO USE: 
    /// A Singleton candidate must satisfy three requirements:
    ///controls concurrent access to a shared resource.
    ///access to the resource will be requested from multiple, disparate parts of the system.
    ///there can be only one object.
    ///If your proposed Singleton has only one or two of these requirements, a redesign is almost always the correct option.
    ///For example, a printer spooler is unlikely to be called from more than one place (the Print menu), so you can use mutexes to solve the concurrent access problem.
    ///A simple logger is the most obvious example of a possibly-valid Singleton, but this can change with more complex logging schemes.
    /// logging, communication,Configuration classes reading from class [may be put in cache for performance hit] and Database access.
    /// 
    /// EXAMPLES: 
    /// 
    /// 
    /// 2. Singleton tasarım şablonu ile geliştirilecek sınıfın tasarımı, sınıfın sadece bir örneğinin oluşturulabilir olmasını sağlayacak şekilde hazırlanmalıdır.
    /// 
    /// Resource: http://www.javablog.org/68-singleton-design-pattern, http://www.blackwasp.co.uk/Singleton.aspx
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static object _lockThis = new object();

        private Singleton()
        {

        }


        /// <summary>
        /// 1. As C# programs can be multithreaded, 
        /// it is possible that two threads could request the singleton before the instance variable is initialised.
        /// In rare cases, these two threads may both create their own copies of the class, defeating the principle of the design pattern. 
        /// By locking the dummy "_lockThis" variable whilst checking, and possibly creating, the instance variable, 
        /// all other threads will be blocked for very brief period.
        /// This means that no two threads will ever be able to simultaneously create their own copies of the object.
        /// 
        /// 2.Java’nın güçlü özelliklerinden biri olan thread (kanal) yapısı sayesinde, birkaç farklı koldan uygulamalar çalıştırılabiliyor.
        /// Peki Singletone nesnemizi, threadlerin sıkça kullanıldığı gelişmiş bir uygulama için tasarlıyor isek ve 2 farklı sınıf,
        /// farklı kanallardan (threads) sınıfımızın getSingletonObject() methoduna erişmeye çalışırsa ne olur? 
        /// Üstelik henüz bir Singleton sınıf örneği oluşturulmamış ise… Birden fazla Singleton nesnemiz oluşturulabilir.
        /// Bu da bizim Singleton tasarım şablonumuz da istemediğimiz bir durum.
        /// </summary>
        /// <returns></returns>
        public static Singleton GetSingleton()
        {
            if (_instance == null)
            {
                lock (_lockThis)
                {
                    if (_instance == null) _instance = new Singleton();
                }
            }

            return _instance;
        }

    }
}
