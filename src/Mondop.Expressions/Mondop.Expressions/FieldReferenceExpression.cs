using System;
using System.Collections.Generic;

namespace Mondop.Expressions
{
    public class FieldReferenceExpression : Expression
    {
        public override void Find(Type type, IList<Expression> target)
        {
            base.Find(type, target);

            Target?.Find(type, target);
        }

        public Expression Target { get; set; }
        public string FieldName { get; set; }
    }
}
