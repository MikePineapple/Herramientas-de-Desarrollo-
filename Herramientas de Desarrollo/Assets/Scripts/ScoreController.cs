using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{   
    public GameObject player;
    public Text scoreText;
    public int score;
    public AudioSource source;
    public AudioClip clipEat;
    public AudioClip clipDead;
    private bool playerIsDead;

    void Update(){
        scoreText.text = score.ToString();

        if (playerIsDead){
            player.GetComponent<BarMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }

    void OnTriggerEnter2D(Collider2D target){
        if (target.gameObject.tag == "Danger")
        {
            StartCoroutine(WaitTilRestart());
            source.PlayOneShot(clipDead);
            Destroy(target.gameObject);
            playerIsDead = true;
        }

        if (target.gameObject.tag == "Coconut"){
            Destroy(target.gameObject);
            score++;
            source.PlayOneShot(clipEat);
        }
    }

    IEnumerator WaitTilRestart()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
