using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ScoreSystem, HealthSystem
{
    public int Health { get; private set; } = 100;
    public int Score { get; private set; } = 0;

    public void ModifyHealth( int amount)
    {
        Health += amount;
        Debug.Log($"Player health: {Health}");
    }

    public void AddScore(int amount)
    {
        Score += amount;
        Debug.Log($"Player score: {Score}");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<InteractableObjects>(out var interactable))
        {
            interactable.Interact(this);
        }
    }
}
