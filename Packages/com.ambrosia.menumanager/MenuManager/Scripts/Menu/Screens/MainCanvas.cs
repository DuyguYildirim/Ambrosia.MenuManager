using Ambrosia.MenuManager;
using UnityEngine;

namespace MenuManager.Scripts.Menu.Screens
{
    public class MainCanvas : Menu<MainCanvas>
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameCanvas.Open();
            }
        }
    }
}