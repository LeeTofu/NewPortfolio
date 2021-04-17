using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIEventHandler : MonoBehaviour, IPointerClickHandler, IDragHandler
{
	public System.Action<PointerEventData> m_clickAction = null;
	public System.Action<PointerEventData> m_DragAction = null;

	public void OnPointerClick(PointerEventData eventData)
	{
		if (m_clickAction != null)
			m_clickAction.Invoke(eventData);
	}

	public void OnDrag(PointerEventData eventData)
	{
		if (m_DragAction != null)
			m_DragAction.Invoke(eventData);
	}
}
