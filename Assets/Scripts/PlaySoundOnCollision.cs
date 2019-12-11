using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        SoundHolder soundHolder = collision.collider.gameObject.GetComponent<SoundHolder>();
        if (soundHolder != null)
        {
            soundHolder.PlaySoundAtPosition(collision.contacts[0].point);
        }
    }
}
