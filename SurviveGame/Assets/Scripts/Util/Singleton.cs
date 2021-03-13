using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    static T s_instance;
    static public T Instance { get { Init(); return s_instance; } }


    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find(typeof(T).Name);

            if(go == null) go = new GameObject(typeof(T).Name);

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<T>();

            s_instance.InitManager();
        }
    }

    public abstract void InitManager(); //매니저 클래스용 추가 Init함수
}
