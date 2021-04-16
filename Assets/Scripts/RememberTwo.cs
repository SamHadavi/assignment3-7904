using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RememberTwo : MonoBehaviour
{
    public GameObject dialogueText;
    public GameObject dialogueBox;
    private bool alreadyTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (alreadyTriggered == false)
        {
            dialogueBox.SetActive(true);
            dialogueText.GetComponent<Text>().text = "There was a mishap and a monster went out of control.. I need to get our of here ASAP!!";
            alreadyTriggered = true;
        }
    }
}
