
namespace NunitSelenium.TestCases.Helpers
{
   public class HudlAccess
    {
//contains basic values use App.config for user id and test
        public string LoginUrl { get; set; } = "https://www.hudl.com/login";
        public string Email { get; set; } = "jeepmtk@gmail.com";
        public string Password { get; set; } = "test123";

        public string NeedHelpMessage { get; set; } = "Need help?";


    }
}
