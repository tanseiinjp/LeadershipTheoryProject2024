using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScript : MonoBehaviour
{
    public static ManagerScript instance {  get; private set; }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        switch (scene.name)
        {
            case "StartScene":
                AudioManager.instance.PlayBGM("StartStage");
                break;
            case "Stage_Test":
                AudioManager.instance.PlayBGM("Stage1");
                break;
            case "Stage1":
                AudioManager.instance.PlayBGM("Stage1");
                break;
            case "ResultStage":
                AudioManager.instance.PlayBGM("ResultStage");
                break;
            case "Kiyoharu_Test":
                AudioManager.instance.PlayBGM("StartStage");
                break;
            case "Kiyoharu":
                AudioManager.instance.PlayBGM("Stage1");
                break;
            default:
                Debug.LogWarning("想定外のステージです。");
                break;
        }
    }
}
