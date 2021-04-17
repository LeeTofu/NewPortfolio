using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public BaseUI m_currentSceneUI;
    Stack<PopupUI> m_popupUIStack = new Stack<PopupUI>();

    public override void InitManager()
    {

    }
}
