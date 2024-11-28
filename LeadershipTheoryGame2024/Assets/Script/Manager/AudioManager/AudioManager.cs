using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //    //BGM(1個)
    //    private AudioSource musicSource;
    //    private AudioClip musicClip;
    //    //SE(n個)
    //    private AudioSource effectSource;
    //    private AudioClip[] effectClip;
    //    private Dictionary<string, AudioClip> dicEffectClip = new Dictionary<string, AudioClip>();
    //    //音声流すかどうか
    //    public bool isOpenAudio = true;
    //    //デフォルトオディオ
    //    public float audioValue = 0.3f;
    //    //void Awake()
    //    //{
    //    //    InitAudio();
    //    //}

    //    public void InitAudioManager()
    //    {
    //        musicSource = GameTool.GetTheChildComponent<AudioSource>(this.gameObject, "AudioSource_Music");
    //        musicClip = Resources.Load<AudioClip>("Audio/MusicAudio/GameMusic");
    //        musicSource.clip = musicClip;

    //        effectSource = GameTool.GetTheChildComponent<AudioSource>(this.gameObject, "AudioSource_Effect");
    //        effectClip = Resources.LoadAll<AudioClip>("Audio/EffectAudio");
    //        for (int i = 0; i < effectClip.Length; i++)
    //        {
    //            dicEffectClip.Add(effectClip[i].name, effectClip[i]);
    //        }

    //        if (!GameTool.HasKey("AudioValue"))
    //        {
    //            GameTool.SetFloat("AudioValue", audioValue);
    //            musicSource.volume = audioValue;
    //            effectSource.volume = audioValue;

    //        }
    //        else
    //        {
    //            float value = GameTool.GetFloat("AudioValue");
    //            musicSource.volume = value;
    //            effectSource.volume = value;
    //            audioValue = value;
    //            // Debug.Log("今のボリューム" + audioValue);
    //        }
    //        PlayMusic();
    //    }
    //    //effectSourceの状態設置
    //    public void SetEffectSourceEnable(bool enable)
    //    {
    //        if (enable)
    //        {
    //            effectSource.clip = null;
    //            effectSource.enabled = true;
    //        }
    //        else
    //        {
    //            effectSource.enabled = false;
    //        }
    //    }
    //    //SEを流す
    //    public void PlayEffectMusic(string effectMusicName)
    //    {
    //        if (!isOpenAudio)
    //        {
    //            return;
    //        }
    //        //for (int i = 0; i < effectClip.Length; i++)
    //        //{
    //        //    if (effectClip[i].name== effectMusicName)
    //        //    {
    //        //        effectSource.clip = effectClip[i];
    //        //        effectSource.Play();
    //        //        break;
    //        //    }
    //        //}
    //        if (dicEffectClip.ContainsKey(effectMusicName))
    //        {
    //            effectSource.clip = dicEffectClip[effectMusicName];
    //            effectSource.Play();
    //        }
    //    }
    //    //BGMを流す
    //    public void PlayMusic()
    //    {
    //        if (GameTool.HasKey("IsOpenAudio"))
    //        {
    //            isOpenAudio = bool.Parse(GameTool.GetString("IsOpenAudio"));
    //        }
    //        else
    //        {
    //            GameTool.SetString("IsOpenAudio", "true");
    //            isOpenAudio = true;
    //        }
    //        if (isOpenAudio)
    //        {
    //            musicSource.Play();
    //        }
    //    }
    //    //音声のオンオフ（BGM,SE）
    //    public void OpenOrCloseAudio(bool isOn)
    //    {
    //        isOpenAudio = !isOn;
    //        if (isOpenAudio)//音声オン
    //        {
    //            musicSource.Play();
    //        }
    //        else//音声オフ
    //        {
    //            musicSource.Pause();
    //        }
    //        GameTool.SetString("IsOpenAudio", isOpenAudio.ToString());
    //    }

    //    //音量大きさの調整
    //    public void SetVolumeValue(float value)
    //    {
    //        musicSource.volume = value;
    //        effectSource.volume = value;
    //        audioValue = value;
    //        GameTool.SetFloat("AudioValue", value);
    //    }
    //}

}