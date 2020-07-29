using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOnStart : MonoBehaviour
{
    [SerializeField]
    private DialogueTrigger Trigger;
    private bool TextStarted;
    public void ButtonStart()
    {
        if (TextStarted == false)
        {
            TextStarted = true;
            Trigger.TriggerDialogue();
        }
        
    }
}
