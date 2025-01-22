using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // InstanceとVolumeの設定
    public static AudioManager instance { get; private set; }
    public float SEVolume { get; private set; }
    public float BGMVolume{ get; private set; }

    // AudioSource（スピーカー）を同時に鳴らしたい音の数だけ用意
    private AudioSource[] audioSourceList = new AudioSource[20];
    private AudioSource BGMSource;

    // 構造体でaudioと名前を関連付ける
    [System.Serializable]
    public struct SoundData
    {
        public string name;
        public AudioClip audioClip;
        public float playedTime;        // 前回再生した時間
    }

    [SerializeField]
    private SoundData[] soundDatas, BGMDatas;
    // 一度再生してから、次再生出来るまでの間隔(秒)
    [SerializeField]
    private float playableDistance = 0.00f;

    // 別名(name)をキーとした管理用Dictionary
    private Dictionary<string, SoundData> soundDictionary = new Dictionary<string, SoundData>();
    private Dictionary<string, SoundData> BGMDictionary = new Dictionary<string, SoundData>();
    // イニシャライズ
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);     // このゲームではルーツになることがないので、コメントアウトしておく
            SEVolume = BGMVolume = 0.3f;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // auidioSourceList配列の数だけAudioSourceを自分自身に生成して配列に格納※オーディオソースの初期化
        for (var i = 0; i < audioSourceList.Length; ++i)
        {
            audioSourceList[i] = gameObject.AddComponent<AudioSource>();
            audioSourceList[i].volume = SEVolume;
        }
        // BGM専属のソースを作って設定をする※BGMソースの初期化
        BGMSource = gameObject.AddComponent<AudioSource>();
        BGMSource.volume = BGMVolume;
        BGMSource.loop = true;

        // Dictionaryの初期化
        foreach (var soundData in soundDatas)
        {
            soundDictionary.Add(soundData.name, soundData);
        }
        foreach (var soundData in BGMDatas)
        {
            BGMDictionary.Add(soundData.name, soundData);
        }
    }

    // 未使用のAudioSourceの取得 全て使用中の場合はnullを返却
    private AudioSource GetUnusedAudioSource()
    {
        for (var i = 0; i < audioSourceList.Length; ++i)
        {
            if (audioSourceList[i].isPlaying == false) return audioSourceList[i];
        }

        return null; //未使用のAudioSourceは見つかりませんでした
    }

    // BGMの再生
    public void PlayBGM(AudioClip clip)
    {
        BGMSource.clip = clip;
        BGMSource.Play();
    }

    public void PlayBGM(string name)
    {
        if (BGMDictionary.TryGetValue(name, out var soundData)) //管理用Dictionary から、別名で探索
        {
            if (Time.realtimeSinceStartup - soundData.playedTime < playableDistance) return;    //まだ再生するには早い
            soundData.playedTime = Time.realtimeSinceStartup; //次回用に今回の再生時間の保持
            // structであるため、手動で書き直す必要があるclass構造は不要
            soundDictionary[name] = soundData;
            PlayBGM(soundData.audioClip); //見つかったら、再生
        }
        else
        {
            Debug.LogWarning($"その別名は登録されていません:{name}");
        }
    }

    // 指定されたAudioClipを未使用のAudioSourceで再生
    public void Play(AudioClip clip)
    {
        var audioSource = GetUnusedAudioSource();
        if (audioSource == null)
        {
            Debug.Log("未使用のオーディオソースがありませんでした");
            return; //再生できませんでした
        }
        audioSource.clip = clip;
        audioSource.Play();
    }
     
    // 指定された別名で登録されたAudioClipを再生
    public void Play(string name)
    {
        if (soundDictionary.TryGetValue(name, out var soundData)) //管理用Dictionary から、別名で探索
        {
            if (Time.realtimeSinceStartup - soundData.playedTime < playableDistance) return;    //まだ再生するには早い
            soundData.playedTime = Time.realtimeSinceStartup; //次回用に今回の再生時間の保持
            // structであるため、手動で書き直す必要があるclass構造は不要
            soundDictionary[name] = soundData;
            Play(soundData.audioClip); //見つかったら、再生
        }
        else
        {
            Debug.LogWarning($"その別名は登録されていません:{name}");
        }
    }

    // 一時停止
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

    // 一時停止の解除
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

    // 音声の打ち切り
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

    // 音量調整用
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