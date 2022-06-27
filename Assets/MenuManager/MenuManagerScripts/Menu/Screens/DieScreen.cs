using MenuManager.Menu.Core;
using MenuManager.Menu.Screens;

namespace EasyClap.Game.Menus
{
    public class DieScreen : Menu<DieScreen>
    {
        public void OnRestartPressed()
        {
            base.OnBackPressed();
            MainMenu.Open();
            //LevelServiceLocator.Instance.ActiveLoader.ReloadCurrentLevel();
        }
    }
}