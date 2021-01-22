using System;

namespace Gerenciador_Ativos.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }
        private DateTime _createdAt;
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = (value == null ? DateTime.UtcNow : value); }
        }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        protected void InsertMetadata(Guid? createdBy)
        {
            CreatedAt = DateTime.Today.Date;
            CreatedBy = createdBy;
        }

        protected void UpdateMetadata(Guid updatedBy)
        {
            UpdatedAt = DateTime.Today.Date;
            UpdatedBy = updatedBy;
        }

        public void Disable()
        {
            Active = false;
        }
    }
}
