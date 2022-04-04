namespace SeleniumSetUu
{
    public static class Config
    {
        public static string baseUrl = "https://www.saucedemo.com/";
        public static string homePageUrl = "https://www.saucedemo.com/inventory.html";

        public static class Credentials
        {
            public static class ValidData
            {
                public static string username = "standard_user";
                public static string validPassword = "secret_sauce";
            }

            public static class InvalidData
            {
                public static string invalidUsername = "standard_user1";
                public static string lockedOutUser = "locked_out_user";
                public static string problemUser = "problem_user";
                public static string performanceGlitchUser = "performance_glitch_user";
                public static string invalidPassword = "not_secret_sauce";
            }
        }

        public static class ErrorsText
        {
            public static string doNotMutchMessage = "Epic sadface: Username and password do not match any user in this service";
            public static string hasBeenLockedMessage = "Epic sadface: Sorry, this user has been locked out.";
        }

        public static class ItemsText
        {
            public static string tShirtText = "Test.allTheThings() T-Shirt (Red)";
        }

        public static class CheckoutData
        {
            public static string firstName = "Robert";
            public static string lastName = "Roberto";
            public static string postalCode = "12345";
        }

    }
}
