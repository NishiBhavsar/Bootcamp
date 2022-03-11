using System;
namespace dependencyinjection {
    public interface I1
    {
        void demo();
    }
    class child1 : I1
    {
        public void demo()
        {
            Console.WriteLine("Child1 Class - Constructor Injection");
        }
    }
    class child2 : I1
    {
        public void demo()
        {
            Console.WriteLine("Child2 Class - Constructor Injection");
        }

    }
    
  public class constructorinjection
    {
        private I1 _i1;

        public constructorinjection(I1 _i1)
        {
            this ._i1 = _i1;
        }

        public void demo()
        {
            _i1.demo();
        }
    }          

    public interface I2
    {
        void demo2();
    }
    public class serviceclass : I2
    {
        public void demo2()
        {
            Console.WriteLine("demo 2 Method overriding");
        }
    }
    public class clientclass
    {
        private I2 _i2;

        public void clientclassmethod(I2 _i2)
        {
            this._i2 = _i2;
            Console.WriteLine("Client Class Method");
            this._i2.demo2();
        }
    }

    public interface I3
    {
        void propertyinjection(string message);
    }

    class Writer1:I3
    {
        public void propertyinjection(string message)
    
        {
          Console.WriteLine("Demo Property Method Class1");
        }
    }

    class Writer2 : I3
    {
        public void propertyinjection(string messages)

        {
            Console.WriteLine("Demo Property Method Class2");
        }
    }

    class demoproperty
    {
        I3? _i3 = null;

        public void demopropertyinjection(I3 _i3, string messages)
        {
            this._i3 = _i3;
            _i3.propertyinjection(messages);
        }


    }

    class program
    {
        static void Main(string[] args)
        {
            constructorinjection cs = null;

            cs = new constructorinjection(new child1());
            cs.demo();

            cs = new constructorinjection(new child2());
            cs.demo();

            clientclass cls= new clientclass();
            cls.clientclassmethod (new serviceclass ());

            demoproperty PIC = new demoproperty();
            PIC.demopropertyinjection(new Writer1(),"Message property value passed");
            PIC.demopropertyinjection(new Writer2(), "Message property value passed");



        }
    }
}