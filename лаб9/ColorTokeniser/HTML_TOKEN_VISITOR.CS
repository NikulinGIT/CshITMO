
namespace CSharp
{ 
    using System;

    public class HTMLTokenVisitor : NullTokenVisitor
    {
        public override void Visit(ILineStartToken line)
        {
            Console.Write(line.Number()); // Not WriteLine
        }
        public override void Visit(ILineEndToken t)
        {
            Console.WriteLine(); // Not Write
        }
        public override void Visit(IIdentifierToken token)
        {
            Console.Write(token.ToString());
        }


       
        public override void Visit(ICommentToken token)
        {
            Console.Write(token.ToString());
        }

        
        public override void Visit(IKeywordToken token)
        {
            Console.Write(token.ToString());
        }

       
        public override void Visit(IWhiteSpaceToken token)
        {
            Console.Write(token.ToString());
        }

    
        public override void Visit(IOtherToken token)
        {
            Console.Write(token.ToString());
        }



    }
}
