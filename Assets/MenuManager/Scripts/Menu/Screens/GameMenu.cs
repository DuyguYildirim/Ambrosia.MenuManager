using MenuManager.Scripts.Menu.Core;

namespace MenuManager.Scripts.Menu.Screens
{
    public class GameMenu : Menu<GameMenu>
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