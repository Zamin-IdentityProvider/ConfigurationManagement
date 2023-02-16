using ConfigurationManagement.Domain.Common.ValueObjects.Names;
using ConfigurationManagement.Domain.IdentityResources.Parameters;
using Zamin.Core.Domain.Entities;

namespace ConfigurationManagement.Domain.IdentityResources.Entities;

public class IdentityResource : AggregateRoot
{
    #region Back Filds
    private List<IdentityResourceClaim> _userClaims { get; set; } = new();
    private List<IdentityResourceProperty> _properties { get; set; } = new();
    #endregion

    #region Properties
    public Name Name { get; private set; }
    public Name DisplayName { get; private set; }
    public string Description { get; private set; }
    public bool Required { get; private set; }
    public bool Emphasize { get; private set; }
    public bool ShowInDiscoveryDocument { get; private set; }
    public bool Enabled { get; private set; }

    public List<IdentityResourceClaim> UserClaims => _userClaims;
    public List<IdentityResourceProperty> Properties => _properties;
    #endregion

    #region Constructors
    private IdentityResource() { }
    private IdentityResource(CreateIdentityResourceParameter parameter) { }
    #endregion

    #region Commands
    public static IdentityResource Create(CreateIdentityResourceParameter parameter) => new(parameter);
    #endregion
}