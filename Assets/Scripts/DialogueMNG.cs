using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueMNG : MonoBehaviour
{
    public Text DialogueText;
    private Queue<string> sentences;
    private string CurrentSentence;
    private int DisplayedChars;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(SentencePack sentencepack)
    {
        sentences.Clear();
        foreach (string sentence in sentencepack.Lines)
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
            DialogueText.text = "";
            CurrentSentence = sentence;
            DisplayedChars = 0;
        }
    }

    private void Update()
    {
        DisplayedChars = Mathf.Min(CurrentSentence.Length, DisplayedChars + 1);
        DialogueText.text = CurrentSentence.Substring(0, DisplayedChars);
        
    }

    public void EndDialogue()
    {
        Debug.Log("Conversation Finished");
    }
}

