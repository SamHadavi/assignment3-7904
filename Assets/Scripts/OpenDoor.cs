using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    AudioSource audioData;
    private bool doorOpened = false;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if (doorOpened == false)
        {
            transform.Rotate(0.0f, 90.0f, 0.0f);
        }
        else
        {
            transform.Rotate(0.0f, -90.0f, 0.0f);
        }
        doorOpened = !doorOpened;
        audioData.Play(0);
    }
}
