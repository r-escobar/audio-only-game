using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{

//    void OnControllerColliderHit(ControllerColliderHit hit)
//    {
//        SoundHolder soundHolder = hit.gameObject.GetComponent<SoundHolder>();
//        if (soundHolder != null)
//        {
//            soundHolder.PlaySoundAtPosition(hit.point);
//        }
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        SoundHolder soundHolder = other.gameObject.GetComponent<SoundHolder>();
//        if (soundHolder != null)
//        {
//            soundHolder.PlaySoundAtPosition(other.ClosestPointOnBounds(transform.position));
//        }
//    }
    
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("player collision enter");
        SoundHolder soundHolder = collision.collider.gameObject.GetComponent<SoundHolder>();
        if (soundHolder != null)
        {
            soundHolder.PlaySoundAtPosition(collision.contacts[0].point);
        }
    }
}
