using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : InteractableObjects
{
    [SerializeField] private Door door;

    public override void Interact(Player player)
    {
        if (door != null)
        {
            door.Open();
            
        }
    }
}
