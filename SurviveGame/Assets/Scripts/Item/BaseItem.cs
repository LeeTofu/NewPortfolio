using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : MonoBehaviour, IPoolableObject, IInteractableObject
{
    public bool m_isUsing { get; set; } = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(GameObject Pool)
    {
        throw new System.NotImplementedException();
    }
}
