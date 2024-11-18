using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task02
{

    public interface IEngine
    {
        void Start();
    }

    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
    }

    public class Car
    {
        private readonly IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void Start()
        {
            _engine.Start();
        }
    }

    public class Program
    {
        public static void Main()
        {
            IEngine engine = new Engine();

            Car car = new Car(engine);

            car.Start();
        }
    }

  
}
