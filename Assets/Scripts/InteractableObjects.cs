using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableObjects : MonoBehaviour
{
    public abstract void Interact(Player player);
}
