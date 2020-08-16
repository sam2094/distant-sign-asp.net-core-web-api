using Common.Attributes;

namespace Common.Enums.DatabaseEnums
{
	public enum Claims : int
	{
        // Certificate | Sign operations
        [EnumDescription("Can create citizen certificate")]
        CAN_CREATE_CITIZEN_CERTIFICATE = 1_0_0_0,
        [EnumDescription("Can create legal certificate")]
        CAN_CREATE_LEGAL_CERTIFICATE = 1_0_0_1,
        [EnumDescription("Can create owner certificate")]
        CAN_CREATE_OWNER_CERTIFICATE = 1_0_0_2,
        [EnumDescription("Can create government certificate")]
        CAN_CREATE_GOVERNMENT_CERTIFICATE = 1_0_0_3,
        [EnumDescription("Can activate certificate")]
        CAN_ACTIVATE_CERTIFICATE = 1_0_0_4,
        [EnumDescription("Can get certificate statuses")]
        CAN_GET_CERTIFICATE_STATUSES = 1_0_0_5,
        [EnumDescription("Can get certificate types")]
        CAN_GET_CERTIFICATE_TYPES = 1_0_0_6,
        [EnumDescription("Can sign")]
        CAN_SIGN = 1_0_0_7,

        //Common
        [EnumDescription("Can get discount types")]
        CAN_GET_DISCOUNT_TYPES = 1_2_0_0,
        [EnumDescription("Can get OTP code statuses")]
        CAN_GET_OTP_CODE_STATUSES = 1_2_0_1,
        [EnumDescription("Can get operation price types")]
        CAN_GET_OPERATION_PRICE_TYPES = 1_2_0_2,
        [EnumDescription("Can get token statuses")]
        CAN_GET_TOKEN_STATUSES = 1_2_0_3,
        [EnumDescription("Can get log types")]
        CAN_GET_LOG_TYPES = 1_2_0_4,
        //[EnumDescription("Can update phone")]
        //CAN_UPDATE_PHONE = 1_2_0_0,
        //[EnumDescription("Can get otp list")]
        //CAN_GET_OTP_LIST = 1_2_0_1,
        //[EnumDescription("Can check otp status")]
        //CAN_CHECK_OTP_STATUS = 1_2_0_2,
        //[EnumDescription("Can recover pincode")]
        //CAN_RECOVER_PINCODE = 1_2_0_3,
        //[EnumDescription("Can get user info")]
        //CAN_GET_USER_INFO = 1_2_0_4,
        //[EnumDescription("Can cancel application")]
        //CAN_CANCEL_APPLICATION = 1_2_0_5,
        //[EnumDescription("Can cahnge role")]
        //CAN_CHANGE_ROLE = 1_2_0_6,
        //[EnumDescription("Can check existance")]
        //CAN_CHECK_EXISTANCE = 1_2_0_7,
        //[EnumDescription("Can add remote bank")]
        //CAN_ADD_REMOTE_BANK = 1_2_0_8,
        //[EnumDescription("Can get remote banks")]
        //CAN_GET_REMOTE_BANKS = 1_2_0_9,
        //[EnumDescription("Can add remote branch")]
        //CAN_ADD_REMOTE_BRANCH = 1_2_1_0,
        //[EnumDescription("Can get remote branchs by bank")]
        //CAN_GET_REMOTE_BRANCHS_BY_BANK = 1_2_1_1,
        //[EnumDescription("Can send sms")]
        //CAN_SEND_SMS = 1_2_1_2,
        //[EnumDescription("Can get remote branches for admin")]
        //CAN_GET_REMOTE_BRANCHES_FOR_ADMIN = 1_2_1_3,
        //[EnumDescription("Can change operator branch")]
        //CAN_CHANGE_OPERATOR_BRANCH = 1_2_1_4,
        //[EnumDescription("Can change direktor branch")]
        //CAN_CHANGE_DIREKTOR_BRANCH = 1_2_1_5,

        //user
        [EnumDescription("Can add a new user")]
        CAN_ADD_USER = 1_4_0_0,
        [EnumDescription("Can block a user")]
        CAN_BLOCK_USER = 1_4_0_1,
        [EnumDescription("Can update user information")]
        CAN_UPDATE_USER = 1_4_0_2,
        [EnumDescription("Can get users")]
        CAN_GET_USERS = 1_4_0_3,
        [EnumDescription("Can set or modify role on user")]
        CAN_SET_OR_MODIFY_ROLE_ON_USER = 1_4_0_4,
        [EnumDescription("Can get user by id")]
        CAN_GET_USER_BY_ID = 1_4_0_5,
        [EnumDescription("Can get user by username")]
        CAN_GET_USER_BY_USERNAME = 1_4_0_6,
        [EnumDescription("Can get remote operator")]
        CAN_GET_REMOTE_OPERATOR = 1_4_0_7,
        [EnumDescription("Can update username")]
        CAN_UPDATE_USERNAME = 1_4_0_8,
        [EnumDescription("Can change password")]
        CAN_CHANGE_PASSWORD = 1_4_0_9,
        [EnumDescription("Can get users for dropdown")]
        CAN_GET_USERS_FOR_DROPDOWN = 1_4_1_0,
        [EnumDescription("Can get gender types")] 
        CAN_GET_GENDER_TYPES = 1_4_1_1,
        [EnumDescription("Can get user statuses")]
        CAN_GET_USER_STATUSES = 1_4_1_2,
        [EnumDescription("Can get citizen types")]
        CAN_GET_CITIZEN_TYPES = 1_4_1_3,
        [EnumDescription("Can get person statuses")]
        CAN_GET_PERSON_STATUSES = 1_4_1_4,
        [EnumDescription("Can get claims")]
        CAN_GET_CLAIMS = 1_4_1_5,
        [EnumDescription("Can get roles")]
        CAN_GET_ROLES = 1_4_1_6,

        //statistic
        [EnumDescription("Can statistic by organization")]
        CAN_GET_STATISTIC_BY_ORGANIZATION = 1_5_0_0,
        [EnumDescription("Can get common statistics")]
        CAN_GET_COMMON_STATISTICS = 1_5_0_1,
        //[EnumDescription("Can get certificate report for user")]
        //CAN_GET_CERTIFICATE_REPORT_FOR_USER = 1_5_0_2,
        //[EnumDescription("Can get log report for user")]
        //CAN_GET_LOG_REPORT_FOR_USER = 1_5_0_3,

        //customer
        [EnumDescription("Can add organization")]
        CAN_ADD_ORGANIZATION = 1_9_0_0,
        [EnumDescription("Can update organization")]
        CAN_UPDATE_ORGANIZATION = 1_9_0_1,
        [EnumDescription("Can get organizations")]
        CAN_GET_ORGANIZATIONS = 1_9_0_2,
        [EnumDescription("Can add branch")]
        CAN_ADD_BRANCH = 1_9_0_3,
        [EnumDescription("Can update branch")]
        CAN_UPDATE_BRANCH = 1_9_0_4,
        [EnumDescription("Can update branch")]
        CAN_GET_BRANCHES = 1_9_0_5,
        [EnumDescription("Can get discounts")]
        CAN_GET_DISCOUNTS = 1_9_0_6,
        //[EnumDescription("Can add user for customer")]
        //CAN_ADD_USER_FOR_CUSTOMER = 1_9_0_4,
        //[EnumDescription("Can update user for customer")]
        //CAN_UPDATE_USER_FOR_CUSTOMER = 1_9_0_5,
        //[EnumDescription("Can get pin and otp code")]
        //CAN_GET_PIN_OTP_CODE = 1_9_0_6,
        //[EnumDescription("Can get pin")]
        //CAN_GET_PIN = 1_9_0_7
    }
}
