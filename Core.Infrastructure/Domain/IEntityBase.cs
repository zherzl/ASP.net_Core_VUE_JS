using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Domain
{
    public interface IEntityBase<TId>
    {
        TId Id { get; set; }
    }

    public class EntityBase<TId> : IEntityBase<TId>
    {
        //TId Id { get; set; }
        public TId Id { get; set; }
    }
}
