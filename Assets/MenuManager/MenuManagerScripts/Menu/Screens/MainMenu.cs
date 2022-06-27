using MenuManager.Menu.Core;
using UnityEngine;

namespace MenuManager.Menu.Screens
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