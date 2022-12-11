using Ambrosia.MenuManager;

namespace MenuManager.Scripts.Menu.Screens
{
    public class WinScreen : Menu<WinScreen>
    {
        public void OnNextLevelPressed()
        {
            MainCanvas.Open();
        }
    }
}