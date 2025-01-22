using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOption : OptionParent
{
    [SerializeField]
    Slider bgmSlider, seSlider;
    [SerializeField]
    GameObject showNextOption, optionobj, backTitleButton;
    float bgm, se;

    public void SetBGMVolume()
    {
        AudioManager.instance.ChangeBGMVolume(bgmSlider.value);
    }

    public void SetSEVolume()
    {
        AudioManager.instance.ChangeSEVolume(seSlider.value);
    }

    public void BackTitle()
    {
        PlaySelectedSound();
        bgmSlider.value = bgm;
        seSlider.value = se;
        SceneManager.LoadScene("StartScene");
    }

    public void ConfirmButton()
    {
        PlaySelectedSound();
        optionobj.SetActive(false);
    }

    public void CancelButton()
    {
        PlaySelectedSound();
        bgmSlider.value = bgm;
        seSlider.value = se;
        optionobj.SetActive(false);
    }

    private void OnEnable()
    {
        bgmSlider.value = bgm = AudioManager.instance.GetBGMVolume();
        seSlider.value = se = AudioManager.instance.GetSEVolume();
        if (showNextOption != null)
        {
            showNextOption.SetActive(false);
        }
        else
        {
            Time.timeScale = 0.0f;
            backTitleButton.SetActive(true);
        }
    }

    private void OnDisable()
    {
        if(showNextOption != null)
        {
            showNextOption.SetActive(true);
        }
        else
        {
            GameManager.instance.SetIsGame(true);
            Time.timeScale = 1.0f;
        }
    }
}
