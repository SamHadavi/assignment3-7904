using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChairMemory : MonoBehaviour
{
    public GameObject dialogueText;
    public GameObject dialogueBox;

    private void OnMouseDown()
    {
        dialogueBox.SetActive(true);
        dialogueText.GetComponent<Text>().text = "*You remember this chair was used to torture you day and night*";
    }

}
