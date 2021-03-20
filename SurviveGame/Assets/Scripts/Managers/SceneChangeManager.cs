using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : Singleton<SceneChangeManager>
{
    public Define.SceneType m_currentSceneType { get; private set; } = Define.SceneType.None;
    public Define.SceneType m_nextSceneType;
    public Base m_currentScene { get; set; }


    public override void InitManager()
    {

    }

    public void LoadNextScene(Define.SceneType nextSceneType)
    {
        if(m_currentScene != null)
        {
            //현재 씬 종료함수
        }

        m_nextSceneType = nextSceneType;
        SceneManager.LoadScene();
    }



}
