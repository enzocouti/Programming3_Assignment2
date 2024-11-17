using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : InteractableObjects
{
    public int healthValue = 10;
    public override void Interact(Player player)
    {
        player.ModifyHealth(healthValue);
        Debug.Log($"Health Increased, Current Health: {player.Health}");
        Destroy(gameObject);
    }
}
