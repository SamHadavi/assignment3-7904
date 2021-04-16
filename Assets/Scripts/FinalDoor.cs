using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour
{
    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        audioData.Play(0);
        Application.Quit();
    }
}
