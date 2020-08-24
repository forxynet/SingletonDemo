using System;

namespace SingletonSample {
    public class Singleton {
        static Singleton singleton;
        public Guid Id;
        public Singleton() {
            Id = Guid.NewGuid();
        }
        public static Singleton GetSingleton() {
            if (singleton == null) {
                singleton = new Singleton();
            }
            return singleton;
        }
    }
    class Program {
        static void Main(string[] args) {

            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"{i}= {Singleton.GetSingleton().Id.ToString()}");
            }
        }
    }
}
