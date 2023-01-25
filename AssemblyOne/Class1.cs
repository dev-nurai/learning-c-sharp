namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        internal int __id = 99;
        protected internal string __name = "Freddy";

    }

    public class AssemblyOneClass2
    {
       public void AssemblyMethodOne()
        {
            AssemblyOneClass1 assemblyOneClass1 = new AssemblyOneClass1();
            Console.Write(assemblyOneClass1.__id);
        }
    }
}