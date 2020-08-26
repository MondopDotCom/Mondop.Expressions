using System;
using System.Collections.Generic;

namespace Mondop.Expressions
{
    public abstract class Expression
    {
        protected Expression()
        {

        }

        public virtual void Find(Type type,IList<Expression> target)
        {
            if (this.GetType() == type)
                target.Add(this);
        }

        public IList<Expression> Find(Type type)
        {
            var result = new List<Expression>();
            Find(type, result);
            return result;
        }
    }
}
