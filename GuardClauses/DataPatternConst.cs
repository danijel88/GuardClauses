namespace GuardClauses
{
    public static class DataPatternConst
    {
        public const string VALID_EMAIL_ADDRESS_PATTERN =
            @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        public const string VALID_URL_PATTERN =
            @"([\w+]+\:\/\/)?([\w\d-]+\.)*[\w-]+[\.\:]\w+([\/\?\=\&\#.]?[\w-]+)*\/?";
    }
}