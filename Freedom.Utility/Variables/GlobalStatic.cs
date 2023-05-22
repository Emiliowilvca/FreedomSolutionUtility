namespace Freedom.Utility.Variables
{
    public static class GlobalStatic
    {
        public static readonly int PasswordMinLength = 6;

        public static readonly int PasswordMaxLength = 20;

        /// <summary>
        /// Password Length 6 and Maximum 20 character,
        /// Require Unique Chars,
        /// Require Digit
        /// Require Lower Case
        /// Require Upper Case
        /// </summary>
        public static readonly string PasswordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,15}$";

        public static readonly string PhoneNumberRegex = @"^[^a-z\s]{4,}$";


        public static readonly string EmailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";


        /// <summary>
        /// https://storage.googleapis.com/imagepro-freedom-app/{imagekey}
        /// </summary>
        public static readonly string GCSBucketImagePath = @"https://storage.googleapis.com/imagepro-freedom-app/";


    }
}