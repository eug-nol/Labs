namespace Clases
{
    public class A
    {
        public void F() { Console.WriteLine("A.F"); }
        public virtual void G() { Console.WriteLine("A.G"); }
    }

    public class B : A
    {
        new public void F() { Console.WriteLine("B.F"); }
        public void G() { Console.WriteLine("B.G"); } // llama a este método aunque no tenga override
    }

}
