using System;
using System.Collections.Generic;
using System.Text;

namespace Mondop.Expressions
{
    public class TypeReferenceExpression: Expression
    {
        public string QualifiedTypeName { get; set; }
    }
}
