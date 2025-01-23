using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneOption : OptionParent
{
    public string sceneName;
    [SerializeField]
    public GameObject option;
    public void StartGame()
    {
        PlaySelectedSound();
        SceneManager.LoadScene(sceneName);
    }

    public void TitleOption()
    {
        PlaySelectedSound();
        option.SetActive(true);
    }

    public void ExitGame()
    {
        PlaySelectedSound();
        Application.Quit();
    }
}
