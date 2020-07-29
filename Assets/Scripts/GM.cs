using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{

    [SerializeField]
    private GameObject PauseMenu;

    //is game paused?
    private bool GameIsPaused = false;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; 

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                UnPauseMenu();
            }
            else
            {
                PausedMenu();
            }
        }
       
    }

    //pause the game
    private void PausedMenu()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
        GameIsPaused = true;
        
    }

    //script the button calls to unpause
    public void UnPauseButton()
    {
        UnPauseMenu();
        foreach (var Movable in FindObjectsOfType<Movable>())
        {
            Movable.UnLockGame();
        }
    }

    //un-pause the game
    private void UnPauseMenu()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        GameIsPaused = false;
    }




}
