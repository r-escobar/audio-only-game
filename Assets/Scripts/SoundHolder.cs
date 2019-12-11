using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHolder : MonoBehaviour
{
    [FMODUnity.EventRef] public string sound;

    public void PlaySoundAtPosition(Vector3 pos)
    {
        FMODUnity.RuntimeManager.PlayOneShot(sound, pos);
    }
}
