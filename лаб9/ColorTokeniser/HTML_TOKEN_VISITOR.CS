
namespace CSharp
{ 
    using System;

    public class HTMLTokenVisitor : NullTokenVisitor
    {
        public void Visit(ILineStartToken line)
        {
            Console.Write(line.Number()); // Not WriteLine
        }
    }

}
