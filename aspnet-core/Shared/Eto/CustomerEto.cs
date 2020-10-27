using System;

namespace Shared.Eto
{
    [Serializable]
    public class CustomerEto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CustomerNumber { get; set; }
        public string Email { get; set; }
        public Guid? CurrentTenantId { get; set; }

        public CustomerEto()
        {

        }
        public CustomerEto(Guid id, string name, string studentCode, string email, Guid? currentTenantId)
        {
            Id = id;
            Name = name;
            CustomerNumber = studentCode;
            Email = email;
            CurrentTenantId = currentTenantId;
        }
    }
}
