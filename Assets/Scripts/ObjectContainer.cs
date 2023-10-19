using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectContainer : MonoBehaviour
{

    public bool isFull;
    public GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameManager.draggingObject != null && isFull == false)
        {
            gameManager.currentContainer = this.gameObject;
        }
    }

    public void OnTriggerExit2D(Collider2D collison)
    {
        gameManager.currentContainer = null;
    }
}
