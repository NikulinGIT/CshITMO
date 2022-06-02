
namespace CSharp
{ 
    using System;

    public class HTMLTokenVisitor : NullTokenVisitor
    {
        public override void Visit(ILineStartToken line)
        {
            Console.WriteLine();
        }
           

              //Console.Write(line.Number()); // Not WriteLine
         }
}
