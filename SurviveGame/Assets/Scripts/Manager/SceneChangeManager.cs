using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : Singleton<SceneChangeManager>
{
    public Define.SceneType m_currentSceneType { get; private set; } = Define.SceneType.None;
    public Define.SceneType m_nextSceneType;
    public BaseScene m_currentScene { get; set; }



    public void LoadScene(Define.SceneType nextSceneType)
    {
        if(m_currentScene != null)
        {
            //현재 씬 종료함수
            m_currentScene.Clear();
        }

        m_nextSceneType = nextSceneType;
        SceneManager.LoadScene(GetSceneName(nextSceneType));
    }

    string GetSceneName(Define.SceneType type)
    {
        string name = System.Enum.GetName(typeof(Define.SceneType), type);
        return name;
    }

    public void Clear()
    {
        m_currentScene.Clear();
    }

    public override void InitManager()
    {

    }
}
