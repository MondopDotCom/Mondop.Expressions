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

        public override void Find(Type type, IList<Expression> target)
        {
            base.Find(type, target);

            Left?.Find(type, target);
            Right?.Find(type, target);
        }

        public Expression Left { get; set; }
        public Expression Right { get; set; }
    }
}
