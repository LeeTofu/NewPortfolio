using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject m_original;
    Queue<IPoolableObject> m_poolQueue = new Queue<IPoolableObject>();

    public void Init(GameObject original, int count = 10)
    {
        m_original = original;

        for (int i = 0; i < count; i++)
            Push(Create(original));
    }

    public IPoolableObject Create(GameObject go)
    {
        return go.GetComponent<IPoolableObject>();
    }

    public IPoolableObject Pop()
    {
        IPoolableObject po;

        if (m_poolQueue.Count == 0)
            Push(Create(m_original));

        IPoolableObject popObject = m_poolQueue.Dequeue();
        popObject.m_isUsing = true;

        return popObject;
    }
    
    public void Push(IPoolableObject po)
    {
        if (po.m_isUsing) return;

       
        po.m_isUsing = false;

        m_poolQueue.Enqueue(po);
    }
}

public class PoolManager : Singleton<PoolManager>
{
    Dictionary<string, ObjectPool> m_poolDicitonary = new Dictionary<string, ObjectPool>();

    public override void InitManager()
    {

    }

    public void CreatePool(GameObject go, int count = 10)
    {
        if (m_poolDicitonary.ContainsKey(go.name)) return;

        ObjectPool pool = new ObjectPool();
        pool.Init(go, count);

        m_poolDicitonary.Add(go.name, pool);
    }

    public void Push(IPoolableObject po)
    {

    }

    public IPoolableObject Pop(GameObject go, Transform parent = null)
    {
        if (!m_poolDicitonary.ContainsKey(go.name)) CreatePool(go);

        return m_poolDicitonary[go.name].Pop();
    }

    public GameObject GetOriginal(string name)
    {
        if (!m_poolDicitonary.ContainsKey(name)) return null;

        return m_poolDicitonary[name].m_original;
    }

    public void Clear()
    {
        foreach(KeyValuePair<string, ObjectPool> poolItem in m_poolDicitonary)
            GameObject.Destroy(poolItem.Value.m_original);

        m_poolDicitonary.Clear();
    }
}
