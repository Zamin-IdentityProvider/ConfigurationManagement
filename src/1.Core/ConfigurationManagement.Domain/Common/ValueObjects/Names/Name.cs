using Zamin.Core.Domain.Exceptions;
using Zamin.Core.Domain.ValueObjects;

namespace ConfigurationManagement.Domain.Common.ValueObjects.Names;

public class Name : BaseValueObject<Name>
{
    #region Properties
    public string Value { get; private set; }
    #endregion

    #region Constructors
    private Name() { }

    public Name(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidValueObjectStateException("ValidationErrorIsRequire", nameof(Name));
        }
        if (value.Length < 2 || value.Length > 250)
        {
            throw new InvalidValueObjectStateException("ValidationErrorStringLength", nameof(Name), "2", "250");
        }
        Value = value;
    }

    #endregion

    #region Commands
    public static Name FromString(string value) => new(value);
    #endregion

    #region Queries
    public override string ToString() => Value;
    #endregion

    #region Equality Check
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    #endregion

    #region Operator Overloading
    public static explicit operator string(Name name) => name.Value;
    public static implicit operator Name(string value) => new(value);
    #endregion
}