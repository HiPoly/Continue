using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueMNG : MonoBehaviour
{

    public Text NameText;
    public Text DialogueText;
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //update textbox
        NameText.text = dialogue.name;
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        else
        {
            string sentence = sentences.Dequeue();
            //update textbox
            DialogueText.text = sentence;
        }
    }

    //need to store the current sentence and update with typewriter effect

    public void EndDialogue()
    {
        Debug.Log("Conversation Finished");
    }
}

