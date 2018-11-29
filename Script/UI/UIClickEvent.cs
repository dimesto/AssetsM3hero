using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIClickEvent : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
       // Debug.Log("OnClickDown");
        this.gameObject.SendMessage("OnClickDown", SendMessageOptions.DontRequireReceiver);
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
       // Debug.Log("OnClickUp");
        this.gameObject.SendMessage("OnClickUp", SendMessageOptions.DontRequireReceiver);
    }

}
