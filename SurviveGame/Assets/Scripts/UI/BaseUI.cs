using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class BaseUI : MonoBehaviour
{
    protected Dictionary<Type, List<UnityEngine.Object>> m_uiObjectDictionary = new Dictionary<Type, List<UnityEngine.Object>>();

    public abstract void InitUI();

    void Start()
    {
        InitUI();
    }

    protected void BindUI<T>(Type type) where T : UnityEngine.Object
    {
        string[] names = Enum.GetNames(type);

        List<UnityEngine.Object> objectList = new List<UnityEngine.Object>(name.Length);
        m_uiObjectDictionary.Add(typeof(T), objectList);

        for (int i = 0; i < names.Length; i++)
        {
            if (typeof(T) == typeof(GameObject))
                objectList[i] = Common.FindChild(gameObject, names[i], true);
            else
                objectList[i] = Common.FindChild<T>(gameObject, names[i], true);

            if (objectList[i] == null)
                Debug.Log($"Failed to bind({names[i]})");
        }
    }

    protected T GetUI<T>(int idx) where T : UnityEngine.Object
    {
        List<UnityEngine.Object> objList = null;
        if (m_uiObjectDictionary.TryGetValue(typeof(T), out objList))
            return objList[idx] as T;

        return null;
    }

    protected GameObject GetObject(int idx) { return GetUI<GameObject>(idx); }
    protected Text GetText(int idx) { return GetUI<Text>(idx); }
    protected Button GetButton(int idx) { return GetUI<Button>(idx); }
    protected Image GetImage(int idx) { return GetUI<Image>(idx); }
}
