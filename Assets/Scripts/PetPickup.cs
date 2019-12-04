using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetPickup : MonoBehaviour
{
    public Vector3 heldPosition;

    private bool isHeld;

    private int numBumps;
    public int bumpsToDrop = 6;

    private Collider col;
    
    [FMODUnity.EventRef] public string pickupSound;
    
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!isHeld)
            {
                isHeld = true;
                transform.parent = other.transform.GetChild(0);
                transform.localRotation = Quaternion.identity;
                transform.localPosition = heldPosition;
                col.enabled = false;
                
                //FMODUnity.RuntimeManager.PlayOneShotAttached(pickupSound, gameObject);
            }
        }
    }
}
