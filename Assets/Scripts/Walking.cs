using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    AudioSource audioData;
    Rigidbody rb;
    bool isMoving = false;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity != Vector3.zero)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        if (isMoving)
        {
            if (!audioData.isPlaying)
                audioData.Play();
        }
        else
            audioData.Stop();
    }
}
