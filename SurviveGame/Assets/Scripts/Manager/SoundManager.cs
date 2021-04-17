using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    Dictionary<Define.SFXType, AudioClip> m_sfxDictionary = new Dictionary<Define.SFXType, AudioClip>();
    Dictionary<Define.BGMType, AudioClip> m_bgmDictionary = new Dictionary<Define.BGMType, AudioClip>();
    AudioSource m_audioSource;

    public override void InitManager()
    {
    }

    public void PlayBGM(Define.BGMType bgmType)
    {

    }

    public void StopBGM()
    {

    }

    public void PlaySFX(Define.SFXType sfxType)
    {

    }

    public void Clear()
    {
        m_sfxDictionary.Clear();
        m_bgmDictionary.Clear();
    }
}
