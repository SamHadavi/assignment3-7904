using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpScare : MonoBehaviour
{
    public GameObject monster;
    public GameObject finalDoor;
    private AudioSource audioData;
    public GameObject dialogueText;
    public GameObject dialogueBox;
    public GameObject rememberOne;
    public GameObject rememberTwo;
    private bool alreadyTriggered = false;

    void Start()
    {
        audioData = monster.gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (alreadyTriggered == false)
        {
            monster.SetActive(true);
            finalDoor.SetActive(true);
            rememberOne.SetActive(true);
            rememberTwo.SetActive(true);
            audioData.Play();
            dialogueBox.SetActive(true);
            dialogueText.GetComponent<Text>().text = "HOLY SHIT!!! I think it's dead..";
            alreadyTriggered = true;
        }
    }
}
