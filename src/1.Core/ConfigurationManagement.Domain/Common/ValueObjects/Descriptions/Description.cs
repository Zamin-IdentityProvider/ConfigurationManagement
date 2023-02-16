using ConfigurationManagement.Domain.Common.ValueObjects.Names;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.Domain.ValueObjects;

namespace ConfigurationManagement.Domain.Common.ValueObjects.Descriptions;

public class Description : BaseValueObject<Description>
{
    #region Properties
    public string Value { get; private set; }
    #endregion

    #region Constructors
    private Description() { }

    public Description(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidValueObjectStateException("ValidationErrorIsRequire", nameof(Description));
        }
        if (value.Length < 1 || value.Length > 500)
        {
            throw new InvalidValueObjectStateException("ValidationErrorStringLength", nameof(Description), "1", "500");
        }
        Value = value;
    }

    #endregion

    #region Commands
    public static Description FromString(string value) => new(value);
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
    public static explicit operator string(Description description) => description.Value;
    public static implicit operator Description(string value) => new(value);
    #endregion
}
