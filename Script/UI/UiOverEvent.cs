using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UiOverEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        this.gameObject.SendMessage("OnOverEnter", SendMessageOptions.DontRequireReceiver);
    }
    
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        this.gameObject.SendMessage("OnOverExit", SendMessageOptions.DontRequireReceiver);
    }
}