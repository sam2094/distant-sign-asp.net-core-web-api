using Common.Attributes;

namespace Common.Enums.DatabaseEnums
{
    public enum CertificateStatuses : byte
    {
        [EnumDescription("Actived")]
        ACTIVE = 1,
        [EnumDescription("Blocked")]
        BLOCKED,

        // TODO revoke certificates
    }
}
