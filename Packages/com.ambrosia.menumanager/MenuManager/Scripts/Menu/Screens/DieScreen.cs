using Ambrosia.MenuManager;

namespace MenuManager.Scripts.Menu.Screens
{
    public class DieScreen : Menu<DieScreen>
    {
        public void OnRestartPressed()
        {
            MainCanvas.Open();
        }
    }
}