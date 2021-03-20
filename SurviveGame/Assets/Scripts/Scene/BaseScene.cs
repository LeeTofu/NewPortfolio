using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseScene : MonoBehaviour
{
    public Define.SceneType m_sceneType { get; protected set; } = Define.SceneType.None;

    // Start is called before the first frame update
    void Awake()
    {
        InitScene();
    }

    // Update is called once per frame
    protected virtual void InitScene()
    {
        
    }

    public abstract void Clear();
}
