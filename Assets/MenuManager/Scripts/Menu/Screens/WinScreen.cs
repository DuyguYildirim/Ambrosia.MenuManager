using MenuManager.Scripts.Menu.Core;

namespace MenuManager.Scripts.Menu.Screens
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