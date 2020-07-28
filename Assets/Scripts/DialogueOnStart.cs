using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOnStart : MonoBehaviour
{

    private bool TextStarted;
    public void ButtonStart()
    {
        if (TextStarted == false)
        {
            TextStarted = true;
            FindObjectOfType<DialogueTrigger>().TriggerDialogue();
        }
        
    }
}
