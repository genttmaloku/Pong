using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour{
   
    public void RestartGame(){

        Time.timeScale = 1f;

        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);

    }

    public void QuitGame(){
        Application.Quit();
    }
  
}
