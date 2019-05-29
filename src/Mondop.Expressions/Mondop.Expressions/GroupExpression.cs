using System.Collections.Generic;

namespace Mondop.Expressions
{
    public class GroupExpression : Expression
    {
        public List<Expression> InnerExpressions { get; set; } = new List<Expression>();
    }
}
