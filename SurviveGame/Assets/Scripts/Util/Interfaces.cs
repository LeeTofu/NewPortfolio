using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPoolableObject
{
    bool m_isUsing { get; set; }

    void Init(GameObject Pool); //초기화 및 해당 오브젝트를 담을 Pool설정
}

public interface IInteractableObject
{

}