using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RememberOne : MonoBehaviour
{
    public GameObject dialogueText;
    public GameObject dialogueBox;
    private bool alreadyTriggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (alreadyTriggered == false)
        {
            dialogueBox.SetActive(true);
            dialogueText.GetComponent<Text>().text = "I remember now! I got captured by our enemy who practices dark soceries by using human sacrifices!!";
            alreadyTriggered = true;
        }
    }
}
