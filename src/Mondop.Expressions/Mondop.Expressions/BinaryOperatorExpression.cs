using System;
using System.Collections.Generic;
using System.Text;

namespace Mondop.Expressions
{
    public abstract class BinaryOperatorExpression : Expression
    {
        protected BinaryOperatorExpression()
        {

        }

        public Expression Left { get; set; }
        public Expression Right { get; set; }
    }
}
