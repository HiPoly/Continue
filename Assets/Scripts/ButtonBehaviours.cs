using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviours : MonoBehaviour
{
    
   //Quit Application
    public void QuitGame()
    {
        Application.Quit();
    }

    //Start the game from the beginning

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }






}
