using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectCard : MonoBehaviour, IDragHandler
{
    public GameObject object_Drag;
    public GameObject object_Game;

    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

}
