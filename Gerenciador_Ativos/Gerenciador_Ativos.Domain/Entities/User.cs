using Gerenciador_Ativos.Domain.Enums;
using System;

namespace Gerenciador_Ativos.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public Profile Profile { get; protected set; }

        protected User() 
        { 
        }

        public User(string name, string email, Profile profile, bool active, Guid createdBy)
        {
            Name = name;
            Email = email;
            Profile = profile;
            Active = active;
            InsertMetadata(createdBy);
        }

        public void Update(string name, string email, Profile profile, bool active, Guid updatedBy)
        {
            Name = name;
            Email = email;
            Profile = profile;
            Active = active;
            UpdateMetadata(updatedBy);
        }
        //fazer validações
    }
}