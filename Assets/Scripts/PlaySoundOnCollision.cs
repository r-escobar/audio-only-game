using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{

    [FMODUnity.EventRef] public string collisionSound;

    private bool isTouching;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!isTouching)
            {
                isTouching = true;
                FMODUnity.RuntimeManager.PlayOneShotAttached(collisionSound, gameObject);
            }
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTouching = false;
        }
    }
}
