using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : BaseScene
{
    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            SceneChangeManager.Instance.LoadScene(Define.SceneType.InGame);
        }
    }

    public override void Clear()
    {

    }

    protected override void InitScene()
    {
        base.InitScene();

        SceneChangeManager.Instance.m_currentScene = this;
        m_sceneType = Define.SceneType.Title;
    }
}
