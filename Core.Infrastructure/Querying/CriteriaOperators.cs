using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Querying
{
    public enum CriteriaOperator
    {
        Equal, LessThanOrEqual, NotApplicable
    }

    public enum QueryOperator
    {
        And,
        Or
    }

    public enum QueryName
    {
        Dynamic = 0,
        RetrieveOrdersUsingAComplexQuery = 1
    }
}
