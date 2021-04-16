using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlippedBedMemory : MonoBehaviour
{
    public GameObject dialogueText;
    public GameObject dialogueBox;

    private void OnMouseDown()
    {
        dialogueBox.SetActive(true);
        dialogueText.GetComponent<Text>().text = "Jesus! What kind of monster could have done this to such a huge bed";
    }

}
