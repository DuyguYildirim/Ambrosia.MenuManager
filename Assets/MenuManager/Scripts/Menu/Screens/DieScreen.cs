using MenuManager.Scripts.Menu.Core;

namespace MenuManager.Scripts.Menu.Screens
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