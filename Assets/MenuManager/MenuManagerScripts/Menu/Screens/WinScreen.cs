using MenuManager.Menu.Core;

namespace MenuManager.Menu.Screens
{
    public class WinScreen : Menu<WinScreen>
    {
        public void OnNextLevelPressed()
        {
            base.OnBackPressed();
            MainMenu.Open();
        }
    }
}