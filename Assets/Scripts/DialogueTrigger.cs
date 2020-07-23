using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public SentencePack sentences;

    private void OnTriggerEnter(Collider other)
    {
        TriggerDialogue();
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueMNG>().StartDialogue(sentences);
    }
}
