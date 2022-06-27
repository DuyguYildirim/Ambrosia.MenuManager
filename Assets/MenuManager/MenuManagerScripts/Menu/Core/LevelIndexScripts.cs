using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MenuManager.Menu.Core
{
    public class LevelIndexScripts : MonoBehaviour
    {
        public static Text _text;
        private static int value;

        private void Awake()
        {
            _text = gameObject.GetComponent<Text>();
            value = PlayerPrefs.GetInt(Constants.Settings.LevelIndex, Constants.Settings.DefaultLevelIndex);
            if (_text)
                _text.text = $"LEVEL {value + 1}";

            int loadingLevelIndex = value % SceneManager.sceneCountInBuildSettings;
            //loadingLevelIndex = loadingLevelIndex == 0 ? 1 : loadingLevelIndex; //eğer 0.leveli atlamak istersen bunu aç
            SceneManager.LoadScene(loadingLevelIndex);
        }
        public static void TextYazdir(int index)
        {
            value = PlayerPrefs.GetInt(Constants.Settings.LevelIndex, Constants.Settings.DefaultLevelIndex);
            if (_text)
                _text.text = $"LEVEL {index + 1}";
        }

    }
}