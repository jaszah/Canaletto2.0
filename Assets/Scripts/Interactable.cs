using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public abstract class Interactable : MonoBehaviour
{
    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }
    public abstract void Interact();

    private void OnTriggerEnter(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            //collision.GetComponent<PointOfInterestMove>().OpenInteractable
            print("contact with object");
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
