using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public SentencePack sentences;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueMNG>().StartDialogue(sentences);
    }
}
