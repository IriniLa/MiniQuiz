using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource buttonpress;

    public void playClickSound()
    {
        buttonpress.Play();
    }
}
