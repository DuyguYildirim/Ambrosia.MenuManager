using MenuManager.Scripts.Menu.Core;
using UnityEngine;

namespace MenuManager.Scripts.Menu.Screens
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