using MenuManager.Menu.Core;
using MenuManager.Menu.Screens;

namespace EasyClap.Game.Menus
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