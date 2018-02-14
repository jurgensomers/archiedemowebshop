using System.Runtime.Serialization;

namespace Archie.Webshop.Api.Models
{
    public enum Gender
    {
        [EnumMember(Value = "male")]
        Male,

        [EnumMember(Value = "female")]
        Female
    }
}