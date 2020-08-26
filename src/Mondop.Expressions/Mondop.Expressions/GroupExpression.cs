using System;
using System.Collections.Generic;

namespace Mondop.Expressions
{
    public class GroupExpression : Expression
    {
        public override void Find(Type type, IList<Expression> target)
        {
            base.Find(type, target);

            if (InnerExpressions != null)
            {
                foreach (var e in InnerExpressions)
                    e?.Find(type, target);
            }
        }

        public List<Expression> InnerExpressions { get; set; } = new List<Expression>();
    }
}
