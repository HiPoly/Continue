using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtonBehaviours : MonoBehaviour
{
    

    private void Start()
    {
       
    }

    //Continue Game/Unpause

    public void Continue()
    {
      GM.FindObjectOfType<GM>().UnPauseButton();

      
    }

    //Retutn to title page, game doesn't get saved
    public void Title()
    {
        TitlePage();
    }

    private void TitlePage()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    //restart the current level

    public void Restart()
    {
        RestartLevel();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Quit game application

    public void Quit()
    {
        QuitGame();
    }

    private void QuitGame()
    {
        Application.Quit();
    }
         



}
