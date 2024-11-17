using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : InteractableObjects
{
    public int damageValue = -10;

    public override void Interact(Player player)
    {
        player.ModifyHealth(damageValue);
        Debug.Log($"Health Decreased, Current Health: {player.Health}");
    }
}
