using System.Collections.Generic;
using UnityEngine;

namespace MenuManager.Scripts.Menu.Core
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private Transform menuParent;
        [SerializeField] private Menu mainMenuPrefab;
        [SerializeField] private Menu[] otherMenuPrefabs;

        private readonly Stack<Menu> _menuStack = new Stack<Menu>();

        public static MenuManager Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                InitializeMenus();
                DontDestroyOnLoad(gameObject);
            }
        }

        private void OnDestroy()
        {
            if (Instance == this)
            {
                Instance = null;
            }
        }

        private void InitializeMenus()
        {
            if (menuParent == null)
            {
                var menuParentObject = new GameObject("Menus");
                menuParent = menuParentObject.transform;
            }

            DontDestroyOnLoad(menuParent.gameObject);

            foreach (var menuPrefab in otherMenuPrefabs)
            {
                var menuInstance = Instantiate(menuPrefab, menuParent);
                menuInstance.gameObject.SetActive(false);
            }

            var mainMenuInstance = Instantiate(mainMenuPrefab, menuParent);
            OpenMenu(mainMenuInstance);
        }

        public void OpenMenu(Menu menuInstance)
        {
            if (menuInstance == null)
            {
                Debug.LogError("MENUMANAGER OpenMenu ERROR: invalid menu");
                return;
            }

            if (_menuStack.Count > 0)
            {
                foreach (var menu in _menuStack)
                {
                    menu.gameObject.SetActive(false);
                }
            }

            menuInstance.gameObject.SetActive(true);
            _menuStack.Push(menuInstance);
        }

        public void CloseMenu()
        {
            if (_menuStack.Count == 0)
            {
                Debug.LogError("MENUMANAGER CloseMenu ERROR: No menus in stack!");
                return;
            }

            var topMenu = _menuStack.Pop();
            topMenu.gameObject.SetActive(false);

            if (_menuStack.Count > 0)
            {
                var nextMenu = _menuStack.Peek();
                nextMenu.gameObject.SetActive(true);
            }
        }
    }
}