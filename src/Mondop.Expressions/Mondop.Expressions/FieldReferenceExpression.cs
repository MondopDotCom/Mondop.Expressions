using System;
using System.Collections.Generic;
using System.Text;

namespace Mondop.Expressions
{
    public class FieldReferenceExpression : Expression
    {
        public Expression Target { get; set; }
        public string FieldName { get; set; }
    }
}
