using System;



namespace OOPS
{
    
    class ClassObjectDemo
    {
       
        public int a;
    }


   
    struct StructureReferenceDemo
    {
        public int a;
    }

   
    public class Encapsulation
    {
        private int pr; 
        internal int i; 
        protected int prot;
        public int pu;
        protected internal int pi;
        private protected int pp;

       
        public Encapsulation()
        {
            pr = 100;
        }

        public void AccessibleDemoFun()
        {
            pr = 10; 
            i = 20; 
            prot = 30; 
            pi = 40; 
            pp = 50;

        }
    }

    
    class EncapsulationAndInheritanceDemo : Encapsulation
    {
        
        public void AccessibleDemoFunOfDirectChildClass()
        {
            
            i = 20; 
            prot = 30;
            pi = 40;
            pp = 60;
        }
    }

    
    class EncapsulationAndInheritanceDemoSubChild : EncapsulationAndInheritanceDemo
    {
        public void AccessibleDemoFunOfSubChildClass()
        {
           
            prot = 20; 
            pi = 30; 
            i = 20; 
            pp = 60;
        }
    }

    class Polymorphism_FunctionOverloading
    {
        public void demo()
        {
            Console.WriteLine("1st demo function in Polymorphism_FunctionOverloading class - no return type, no parameter.");
        }
        public void demo(int a)
        {
            Console.WriteLine("2nd demo function in Polymorphism_FunctionOverloading class - no return type, 1 integer parameter");
        }
        public void demo(int a, char b)
        {
            Console.WriteLine("3rd demo function in Polymorphism_FunctionOverloading class - no return type, 1 integer parameter + 1 character parameter.");
        }
    }

    class Base_Cls
    {
        public virtual void DemoFunction()
        {
            Console.WriteLine("Base_Cls Saying Hello!");
        }
        public void DemoFunction2()
        {
            Console.WriteLine("Base_Cls Saying Hello second time!");
        }
    }
    class Derived_Cls : Base_Cls
    {
        public override void DemoFunction()
        {
            base.DemoFunction();
            Console.WriteLine("Derived_Cls Saying Hello!");
        }
        public void DemoFunction2()
        {
            Console.WriteLine("Derived_Cls Saying Hello second time!");
        }

    }
    class Derived_Sub_Cls : Derived_Cls
    {
        public override void DemoFunction()
        {
            base.DemoFunction();
            Console.WriteLine("Derived_Sub_Cls Saying Hello!");
        }
        public void DemoFunction2()
        {
            Console.WriteLine("Derived_Sub_Cls Saying Hello second time!");
        }
    }

    abstract class Parent_AbsCls
    {
        public void DemoParentAbsNormal_Fun()
        {
            Console.WriteLine("Normal Method of Normal Class Named - Parent_AbsCls is called.");
        }
        public abstract void DemoParentAbsAbstract_Fun();
    }

    abstract class Abstract_CLS : Parent_AbsCls
    {
        public abstract void DemoABS_Fun();
        public void DemoNormal_Fun()
        {
            Console.WriteLine("Normal Method of Abstract Class Named - Abstract_CLS is called.");
        }

        public override void DemoParentAbsAbstract_Fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - Parent_AbsCls is called IN Abstract_CLS.");
        }
    }

    class ChildCLS_AbsDemo : Abstract_CLS
    {
        public override void DemoABS_Fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - Abstract_CLS is called.");
        }
        public void DemoChildNormal_Fun()
        {
            Console.WriteLine("Normal Method of Child Class Named - ChildCLS_AbsDemo is called.");
        }

        public override void DemoParentAbsAbstract_Fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - Parent_AbsCls is called IN ChildCLS_AbsDemo.");
        }
    }

    interface IParent
    {
        void IAbsDemo();
    }
    interface IParent2
    {
        void IAbsDemo();
    }
    class InterfaceDemo_CLS : IParent, IParent2
    {
        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }
    class InterfaceDemo_CLS2 : IParent, IParent2
    {

        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }
    class InterfaceDemo_CLS3 : IParent, IParent2
    {

        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }

   
    static class DemoStaticCLS
    {
        public static int a;
    }

    class DemoStaticCLSWithNormal
    {
        public int a1;

        
        public static int b;
    }


    
    public class NormalSealedCLSDemo
    {
        public int a2 = 300;
    }

   
    sealed class DemoSealedCLS : NormalSealedCLSDemo
    {
        public int InheritDemo;
    }

    public partial class DemoParCLS
    {
        public int p1;
    }

    public partial class DemoParCLS
    {
        public int p2;
    }


    public class ChildCLS : DemoParCLS
    {
        public int child;
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            ClassObjectDemo ClassObjectDemo1 = new ClassObjectDemo();
            ClassObjectDemo ClassObjectDemo2 = new ClassObjectDemo();
            ClassObjectDemo ClassObjectDemo3 = new ClassObjectDemo();
            ClassObjectDemo ClassObjectDemo4 = new ClassObjectDemo();           
            ClassObjectDemo ClassObjectDemo5 = new ClassObjectDemo();            
            ClassObjectDemo ClassObjectDemo6 = ClassObjectDemo1;
           

            ClassObjectDemo1.a = 100;
            ClassObjectDemo2.a = 200;
            ClassObjectDemo3.a = 300;
            ClassObjectDemo4.a = 400;
            ClassObjectDemo5.a = 500;
            ClassObjectDemo6.a = 600;
            

            
            Console.WriteLine("Value of ClassObjectDemo1.a:" + ClassObjectDemo1.a);
            Console.WriteLine("Value of ClassObjectDemo2.a:" + ClassObjectDemo2.a);
            Console.WriteLine("Value of ClassObjectDemo3.a:" + ClassObjectDemo3.a);
            Console.WriteLine("Value of ClassObjectDemo4.a:" + ClassObjectDemo4.a);
            Console.WriteLine("Value of ClassObjectDemo5.a:" + ClassObjectDemo5.a);
            Console.WriteLine("Value of ClassObjectDemo6.a:" + ClassObjectDemo6.a);
           

            
            StructureReferenceDemo StructureReferenceDemo1 = new StructureReferenceDemo();          
            StructureReferenceDemo StructureReferenceDemo2 = new StructureReferenceDemo();
            StructureReferenceDemo StructureReferenceDemo3 = new StructureReferenceDemo();            
            StructureReferenceDemo StructureReferenceDemo4 = new StructureReferenceDemo();
            StructureReferenceDemo StructureReferenceDemo5 = new StructureReferenceDemo();

           
            
            StructureReferenceDemo1.a = 111;
            StructureReferenceDemo2.a = 222;
            StructureReferenceDemo3.a = 333;
            StructureReferenceDemo4.a = 444;
            StructureReferenceDemo5.a = 555;
           

            
            Console.WriteLine("Value of StructureReferenceDemo1.a:" + StructureReferenceDemo1.a);
            Console.WriteLine("Value of StructureReferenceDemo2.a:" + StructureReferenceDemo2.a);
            Console.WriteLine("Value of StructureReferenceDemo3.a:" + StructureReferenceDemo3.a);
            Console.WriteLine("Value of StructureReferenceDemo4.a:" + StructureReferenceDemo4.a);
            Console.WriteLine("Value of StructureReferenceDemo5.a:" + StructureReferenceDemo5.a);
            


           
            Encapsulation En = new Encapsulation();
            En.i = 100; 
            En.pi = 101; 
            En.pu = 102;

            EncapsulationAndInheritanceDemo EnI = new EncapsulationAndInheritanceDemo();
            EnI.i = 100; 
            EnI.pi = 101;
            EnI.pu = 102; 

            Console.WriteLine("Intenal Variable Value:" + En.i + "-" + EnI.i);
            Console.WriteLine("Protected Intenal Variable Value:" + En.pi + "-" + EnI.pi);
            Console.WriteLine("Public Variable Value:" + En.pu + "-" + EnI.pu);

           
            EncapsulationAndInheritanceDemoSubChild EnIDSC = new EncapsulationAndInheritanceDemoSubChild();
            EnIDSC.i = 100; 
            EnIDSC.pi = 101; 
            EnIDSC.pu = 102; 

            Console.WriteLine("Intenal Variable Value:" + En.i + "-" + EnI.i + "-" + EnIDSC.i);
            Console.WriteLine("Protected Intenal Variable Value:" + En.pi + "-" + EnI.pi + "-" + EnIDSC.pi);
            Console.WriteLine("Public Variable Value:" + En.pu + "-" + EnI.pu + "-" + EnIDSC.pu);

           
            OOPS_Demo_Inheritance.EncapsulationAndInheritanceDemoInDifferentNameSpace OOPSD_EnI = new OOPS_Demo_Inheritance.EncapsulationAndInheritanceDemoInDifferentNameSpace();
            OOPSD_EnI.i = 100; 
            OOPSD_EnI.pi = 101; 
            OOPSD_EnI.pu = 102; 
            Console.WriteLine("Intenal Variable Value:" + En.i + "-" + EnI.i + "-" + OOPSD_EnI.i);
            Console.WriteLine("Protected Intenal Variable Value:" + En.pi + "-" + EnI.pi + "-" + OOPSD_EnI.pi);
            Console.WriteLine("Public Variable Value:" + En.pu + "-" + EnI.pu + "-" + OOPSD_EnI.pu);


            
            Polymorphism_FunctionOverloading PolyFunOverLoading = new Polymorphism_FunctionOverloading();
            PolyFunOverLoading.demo(); 
            PolyFunOverLoading.demo(1);
            PolyFunOverLoading.demo(1, 'A');

            Base_Cls B_CLS = new Base_Cls();
            B_CLS.DemoFunction(); 
            B_CLS.DemoFunction2(); 

            Derived_Cls D_CLS = new Derived_Cls();
            D_CLS.DemoFunction(); 
            D_CLS.DemoFunction2(); 

            Derived_Sub_Cls DS_CLS = new Derived_Sub_Cls();
            DS_CLS.DemoFunction(); 
            DS_CLS.DemoFunction2(); 


           
            ChildCLS_AbsDemo CCLS_AbsDemo = new ChildCLS_AbsDemo();
            CCLS_AbsDemo.DemoNormal_Fun();
            CCLS_AbsDemo.DemoABS_Fun();
            CCLS_AbsDemo.DemoChildNormal_Fun();
            CCLS_AbsDemo.DemoParentAbsNormal_Fun();
            CCLS_AbsDemo.DemoParentAbsAbstract_Fun();

            Abstract_CLS AbCLS = new ChildCLS_AbsDemo(); 
            AbCLS.DemoABS_Fun();
            AbCLS.DemoNormal_Fun();
            AbCLS.DemoParentAbsNormal_Fun();
            AbCLS.DemoParentAbsAbstract_Fun();


            IParent ICls = new InterfaceDemo_CLS();
            ICls.IAbsDemo();

            ICls = new InterfaceDemo_CLS2();
            ICls.IAbsDemo();

            ICls = new InterfaceDemo_CLS3();
            ICls.IAbsDemo();


           
            DemoStaticCLS.a = 10;


            DemoStaticCLSWithNormal DSWN = new DemoStaticCLSWithNormal();
            DSWN.a1 = 100;

           
            DemoStaticCLSWithNormal.b = 200;

            DemoParCLS DPC = new DemoParCLS();
            DPC.p1 = 300;
            DPC.p2 = 400;

            ChildCLS CCLS = new ChildCLS();
            CCLS.p1 = 1000;
            CCLS.p2 = 1000;

            Console.ReadKey();
        }
    }
}


namespace OOPS_Demo_Inheritance
{

    
    class EncapsulationAndInheritanceDemoInDifferentNameSpace : OOPS.Encapsulation
    {
       
        public void AccessibleDemoFunOfDirectChildClassInDifferentNameSpace()
        {
            prot = 20; 
            pi = 30; 
            i = 20; 
            pp = 60;
        }
    }

}

