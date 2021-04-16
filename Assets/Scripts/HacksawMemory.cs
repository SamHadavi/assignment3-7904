using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HacksawMemory : MonoBehaviour
{
    public GameObject dialogueText;
    public GameObject dialogueBox;

    private void OnMouseDown()
    {
        dialogueBox.SetActive(true);
        dialogueText.GetComponent<Text>().text = "Ugh, this brings back bad memories.. let's not think about it";
    }
}
