using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private bool LevelWon;

    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.tag == "Ball")
        {
            //Destroy the ball
            Destroy(Collision.gameObject);
            LevelWon = true;
            FindObjectOfType<DialogueTrigger>().TriggerDialogue();

        }
    }
}
