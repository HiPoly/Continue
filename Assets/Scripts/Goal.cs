using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private string NextLevel;
    private bool LevelWon = false;

    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.tag == "Ball")
        {
            //Destroy the ball
            Destroy(Collision.gameObject);
            LevelWon = true;
            //start the dialogue (In Other Script)

            //LoadtheNextLevel
            SceneManager.LoadScene(NextLevel);
            Debug.Log("I should be loading a level");

        }
    }
}
