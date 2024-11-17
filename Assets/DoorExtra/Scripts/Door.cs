using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
   private bool isOpen = false;

    public void Open()
    {
        if (isOpen)
        {
            Debug.Log("Door already open");
            return;
        }

        isOpen = true;
        Debug.Log("Door open");
        gameObject.SetActive(false);
    }
}
