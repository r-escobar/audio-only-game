using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PetHolder : MonoBehaviour
{
    public List<GameObject> heldPets = new List<GameObject>();

    public int curBumpCount;
    public int bumpsToDropPet = 5;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (heldPets.Count > 0)
        {
            curBumpCount++;
            if (curBumpCount >= bumpsToDropPet)
            {
                int randIndex = Random.Range(0, heldPets.Count);
                heldPets[randIndex].transform.parent = null;
                heldPets[randIndex].GetComponent<PetPickup>().Drop();
                heldPets.RemoveAt(randIndex);
                curBumpCount = 0;
            }    
        }
        else
        {
            curBumpCount = 0;
        }
        
    }
}
