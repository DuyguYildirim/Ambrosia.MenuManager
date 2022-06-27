using MenuManager.Menu.Core;

namespace MenuManager.Menu.Screens
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