using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    bool isGame = false;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);     // このゲームではルーツになることがないので、コメントアウトしておく
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetIsGame(bool b)
    {
        isGame = b;
    }
    public bool GetIsGame()
    {
        return isGame;
    }
}
