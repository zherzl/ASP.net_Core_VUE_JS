using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Querying
{
    public class OrderByClause
    {
        public string PropertyName { get; set; }
        public bool Desc { get; set; }

        public static OrderByClause Create(string propertyName, bool desc)
        {
            return new OrderByClause
            {
                PropertyName = propertyName,
                Desc = desc
            };
        }
    }
}
