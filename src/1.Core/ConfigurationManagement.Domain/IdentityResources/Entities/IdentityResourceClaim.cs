using Zamin.Core.Domain.Entities;

namespace ConfigurationManagement.Domain.IdentityResources.Entities;

public class IdentityResourceClaim : Entity
{
    public string Type { get; private set; }

    public int IdentityResourceId { get; private set; }
    public IdentityResource IdentityResource { get; private set; }
}