using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : InteractableObjects
{
    public override void Interact(Player player)
    {
        player.AddScore(1);
        Debug.Log($"Coin Collected, total coins: {player.Score}");
        Destroy(gameObject);
    }
}
