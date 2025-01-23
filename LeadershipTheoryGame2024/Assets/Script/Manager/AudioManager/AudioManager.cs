using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Instance��Volume�̐ݒ�
    public static AudioManager instance { get; private set; }
    public float SEVolume { get; private set; }
    public float BGMVolume{ get; private set; }

    // AudioSource�i�X�s�[�J�[�j�𓯎��ɖ炵�������̐������p��
    private AudioSource[] audioSourceList = new AudioSource[20];
    private AudioSource BGMSource;

    // �\���̂�audio�Ɩ��O���֘A�t����
    [System.Serializable]
    public struct SoundData
    {
        public string name;
        public AudioClip audioClip;
        public float playedTime;        // �O��Đ���������
    }

    [SerializeField]
    private SoundData[] soundDatas, BGMDatas;
    // ��x�Đ����Ă���A���Đ��o����܂ł̊Ԋu(�b)
    [SerializeField]
    private float playableDistance = 0.00f;

    // �ʖ�(name)���L�[�Ƃ����Ǘ��pDictionary
    private Dictionary<string, SoundData> soundDictionary = new Dictionary<string, SoundData>();
    private Dictionary<string, SoundData> BGMDictionary = new Dictionary<string, SoundData>();
    // �C�j�V�����C�Y
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);     // ���̃Q�[���ł̓��[�c�ɂȂ邱�Ƃ��Ȃ��̂ŁA�R�����g�A�E�g���Ă���
            SEVolume = BGMVolume = 0.3f;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // auidioSourceList�z��̐�����AudioSource���������g�ɐ������Ĕz��Ɋi�[���I�[�f�B�I�\�[�X�̏�����
        for (var i = 0; i < audioSourceList.Length; ++i)
        {
            audioSourceList[i] = gameObject.AddComponent<AudioSource>();
            audioSourceList[i].volume = SEVolume;
        }
        // BGM�ꑮ�̃\�[�X������Đݒ�����遦BGM�\�[�X�̏�����
        BGMSource = gameObject.AddComponent<AudioSource>();
        BGMSource.volume = BGMVolume;
        BGMSource.loop = true;

        // Dictionary�̏�����
        foreach (var soundData in soundDatas)
        {
            soundDictionary.Add(soundData.name, soundData);
        }
        foreach (var soundData in BGMDatas)
        {
            BGMDictionary.Add(soundData.name, soundData);
        }
    }

    // ���g�p��AudioSource�̎擾 �S�Ďg�p���̏ꍇ��null��ԋp
    private AudioSource GetUnusedAudioSource()
    {
        for (var i = 0; i < audioSourceList.Length; ++i)
        {
            if (audioSourceList[i].isPlaying == false) return audioSourceList[i];
        }

        return null; //���g�p��AudioSource�͌�����܂���ł���
    }

    // BGM�̍Đ�
    public void PlayBGM(AudioClip clip)
    {
        BGMSource.clip = clip;
        BGMSource.Play();
    }

    public void PlayBGM(string name)
    {
        if (BGMDictionary.TryGetValue(name, out var soundData)) //�Ǘ��pDictionary ����A�ʖ��ŒT��
        {
            if (Time.realtimeSinceStartup - soundData.playedTime < playableDistance) return;    //�܂��Đ�����ɂ͑���
            soundData.playedTime = Time.realtimeSinceStartup; //����p�ɍ���̍Đ����Ԃ̕ێ�
            // struct�ł��邽�߁A�蓮�ŏ��������K�v������class�\���͕s�v
            soundDictionary[name] = soundData;
            PlayBGM(soundData.audioClip); //����������A�Đ�
        }
        else
        {
            Debug.LogWarning($"���̕ʖ��͓o�^����Ă��܂���:{name}");
        }
    }

    // �w�肳�ꂽAudioClip�𖢎g�p��AudioSource�ōĐ�
    public void Play(AudioClip clip)
    {
        var audioSource = GetUnusedAudioSource();
        if (audioSource == null)
        {
            Debug.Log("���g�p�̃I�[�f�B�I�\�[�X������܂���ł���");
            return; //�Đ��ł��܂���ł���
        }
        audioSource.clip = clip;
        audioSource.Play();
    }
     
    // �w�肳�ꂽ�ʖ��œo�^���ꂽAudioClip���Đ�
    public void Play(string name)
    {
        if (soundDictionary.TryGetValue(name, out var soundData)) //�Ǘ��pDictionary ����A�ʖ��ŒT��
        {
            if (Time.realtimeSinceStartup - soundData.playedTime < playableDistance) return;    //�܂��Đ�����ɂ͑���
            soundData.playedTime = Time.realtimeSinceStartup; //����p�ɍ���̍Đ����Ԃ̕ێ�
            // struct�ł��邽�߁A�蓮�ŏ��������K�v������class�\���͕s�v
            soundDictionary[name] = soundData;
            Play(soundData.audioClip); //����������A�Đ�
        }
        else
        {
            Debug.LogWarning($"���̕ʖ��͓o�^����Ă��܂���:{name}");
        }
    }

    // �ꎞ��~
    public void PauseBGM()
    {
        BGMSource.Pause();
    }
    public void PauseAllSE()
    {
        for (var i = 0; i < audioSourceList.Length; ++i)
        {
            audioSourceList[i].Pause();
        }
    }
    public void PauseAudio()
    {
        PauseBGM();
        PauseAllSE();
    }

    // �ꎞ��~�̉���
    public void UnPauseBGM()
    {
        BGMSource.UnPause();
    }
    public void UnPauseAllSE()
    {
        for (var i = 0; i < audioSourceList.Length; ++i)
        {
            audioSourceList[i].UnPause();
        }
    }
    public void UnPauseAudio()
    {
        UnPauseBGM();
        UnPauseAllSE();
    }

    // �����̑ł��؂�
    public void StopBGM()
    {
        BGMSource.Stop();
    }
    public void StopAllSE()
    {
        for (var i = 0; i < audioSourceList.Length; ++i)
        {
            audioSourceList[i].Stop();
        }
    }
    public void StopAudio()
    {
        StopBGM();
        StopAllSE();
    }

    // ���ʒ����p
    public void ChangeBGMVolume(float volume)
    {
        BGMSource.volume = BGMVolume = volume;
    }
    public void ChangeSEVolume(float value)
    {
        SEVolume = value;
        for (var i = 0; i < audioSourceList.Length; ++i)
        {
            audioSourceList[i].volume = SEVolume;
        }
    }
    public float GetBGMVolume()
    {
        return BGMVolume;
    }
    public float GetSEVolume()
    {
        return SEVolume;
    }
}