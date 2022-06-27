using MenuManager.Menu.Core;
using MenuManager.Menu.Screens;

namespace EasyClap.Game.Menus
{
    public class DieScreen : Menu<DieScreen>
    {
        public void OnRestartPressed()
        {
            base.OnBackPressed();
            //LevelServiceLocator.Instance.ActiveLoader.ReloadCurrentLevel();
            MainMenu.Open();
        }
    }
}