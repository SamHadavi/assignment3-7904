using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RitualMemory : MonoBehaviour
{
    public GameObject dialogueText;
    public GameObject dialogueBox;

    private void OnMouseDown()
    {
        dialogueBox.SetActive(true);
        dialogueText.GetComponent<Text>().text = "What the hell is this?!?";

    }
}
