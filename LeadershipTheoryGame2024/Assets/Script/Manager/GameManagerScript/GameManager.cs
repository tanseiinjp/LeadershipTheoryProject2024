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
            //DontDestroyOnLoad(gameObject);     // ���̃Q�[���ł̓��[�c�ɂȂ邱�Ƃ��Ȃ��̂ŁA�R�����g�A�E�g���Ă���
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
