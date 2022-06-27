using MenuManager.Menu.Core;

namespace MenuManager.Menu.Screens
{
    public class DieScreen : Menu<DieScreen>
    {
        public void OnRestartPressed()
        {
            base.OnBackPressed();
            MainMenu.Open();
        }
    }
}