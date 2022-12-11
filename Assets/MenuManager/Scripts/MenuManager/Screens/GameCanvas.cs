using Ambrosia.MenuManager;

namespace MenuManager.Scripts.Menu.Screens
{
    public class GameCanvas : Menu<GameCanvas>
    {
        public void WinScreenOpen()
        {
            WinScreen.Open();
        }

        public void DieScreenOpen()
        {
            DieScreen.Open();
        }
    }
}