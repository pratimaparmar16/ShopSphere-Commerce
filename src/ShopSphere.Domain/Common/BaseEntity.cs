using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; private set; }

        public DateTime? ModifiedDate { get; private set; }

        public bool IsDeleted { get; private set; }

        protected BaseEntity()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public void MarkAsDeleted()
        {
            IsDeleted = true;
        }

        public void UpdateModifiedDate()
        {
            ModifiedDate = DateTime.UtcNow;
        }
    }
}
