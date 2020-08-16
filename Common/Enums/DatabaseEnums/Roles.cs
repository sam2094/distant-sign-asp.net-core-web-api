using Common.Attributes;

namespace Common.Enums.DatabaseEnums
{
    public enum Roles : int
    {
        [EnumDescription("Super Admin")]
        SUPER_ADMIN = 1_0_0_0,
        [EnumDescription("Organization Admin")]
        ORG_ADMIN = 2_0_0_0,
        [EnumDescription("Manager")]
        MANAGER = 2_0_0_1,
        [EnumDescription("Operator")]
        OPERATOR = 2_0_0_2,
        [EnumDescription("Seller")]
        SELLER = 2_0_0_3
    }
}
