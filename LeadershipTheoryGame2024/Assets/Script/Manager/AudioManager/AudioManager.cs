using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //    //BGM(1��)
    //    private AudioSource musicSource;
    //    private AudioClip musicClip;
    //    //SE(n��)
    //    private AudioSource effectSource;
    //    private AudioClip[] effectClip;
    //    private Dictionary<string, AudioClip> dicEffectClip = new Dictionary<string, AudioClip>();
    //    //�����������ǂ���
    //    public bool isOpenAudio = true;
    //    //�f�t�H���g�I�f�B�I
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
    //            // Debug.Log("���̃{�����[��" + audioValue);
    //        }
    //        PlayMusic();
    //    }
    //    //effectSource�̏�Ԑݒu
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
    //    //SE�𗬂�
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
    //    //BGM�𗬂�
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
    //    //�����̃I���I�t�iBGM,SE�j
    //    public void OpenOrCloseAudio(bool isOn)
    //    {
    //        isOpenAudio = !isOn;
    //        if (isOpenAudio)//�����I��
    //        {
    //            musicSource.Play();
    //        }
    //        else//�����I�t
    //        {
    //            musicSource.Pause();
    //        }
    //        GameTool.SetString("IsOpenAudio", isOpenAudio.ToString());
    //    }

    //    //���ʑ傫���̒���
    //    public void SetVolumeValue(float value)
    //    {
    //        musicSource.volume = value;
    //        effectSource.volume = value;
    //        audioValue = value;
    //        GameTool.SetFloat("AudioValue", value);
    //    }
    //}

}