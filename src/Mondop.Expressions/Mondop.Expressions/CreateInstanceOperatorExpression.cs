using System;
using System.Collections.Generic;

namespace Mondop.Expressions
{
    public class CreateInstanceOperatorExpression: Expression
    {
        public override void Find(Type type, IList<Expression> target)
        {
            base.Find(type, target);

            Type?.Find(type, target);
        }

        public TypeReferenceExpression Type { get; set; }
    }
}
