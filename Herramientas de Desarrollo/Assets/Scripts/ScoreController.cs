using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    public int score;

    void Update(){
        scoreText.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D target){
        if (target.gameObject.tag == "Danger")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if (target.gameObject.tag == "Coconut"){
            Destroy(target.gameObject);
            score++;
        }
    }
}
