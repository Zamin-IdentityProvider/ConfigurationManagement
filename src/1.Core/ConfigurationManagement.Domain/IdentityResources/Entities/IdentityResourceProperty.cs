using Zamin.Core.Domain.Entities;

namespace ConfigurationManagement.Domain.IdentityResources.Entities;

public class IdentityResourceProperty : Entity
{
    public string Key { get; private set; }
    public string Value { get; private set; }
    public int IdentityResourceId { get; private set; }
    public IdentityResource IdentityResource { get; private set; }
}