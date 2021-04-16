using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject dialogueBox;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            dialogueBox.SetActive(false);
        }
    }
}
