using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseMenuUI;

    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (gamePaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        gamePaused = false;
    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }
} 
