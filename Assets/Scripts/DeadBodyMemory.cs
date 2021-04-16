using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeadBodyMemory : MonoBehaviour
{
    public GameObject dialogueText;
    public GameObject dialogueBox;

    private void OnMouseDown()
    {
        dialogueBox.SetActive(true);
        dialogueText.GetComponent<Text>().text = "Poor guy.. They must have done a number on him";
    }
}
