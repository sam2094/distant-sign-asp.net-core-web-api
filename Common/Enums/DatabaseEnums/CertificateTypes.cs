using Common.Attributes;

namespace Common.Enums.DatabaseEnums
{
    public enum CertificateTypes : byte
    {
        [EnumDescription("Citizen")]
        CITIZEN = 1,
        [EnumDescription("Legal")]
        LEGAL,
        [EnumDescription("Government")]
        GOVERNMENT,
        [EnumDescription("Owner")]
        OWNER = 5
    }
}
