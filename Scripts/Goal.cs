using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour{
   

    public int score = 0;
    public string name;
    public Color color;
    public Text scoreText;
    public Text gameOverText;
    public GameObject gameOverScreen;

    public void AddScore(){

        score++;

        Debug.Log(gameObject.name + " Score: " +  score);
        scoreText.text = score.ToString();

        if(score >= 5){
            gameOverText.text = name + " Player Wins!";
            gameOverText.color = color;

            gameOverScreen.SetActive(true);

            Time.timeScale = 0f;
        }


    }
}
