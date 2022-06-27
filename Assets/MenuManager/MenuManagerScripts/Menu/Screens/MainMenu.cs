using MenuManager.Menu.Core;
using UnityEngine;

namespace EasyClap.Game.Menus
{
    public class MainMenu : Menu<MainMenu>
    {
        private void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {
                gameObject.SetActive(false);
                GameMenu.Open();
            }
        }
    }
}