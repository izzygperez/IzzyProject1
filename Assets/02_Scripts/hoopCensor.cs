using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hoopCensor : MonoBehaviour
{
    public GameObject effectObject;
    int score = 0;
    [SerializeField] score scoreScript;

    private void Start()
    {
        effectObject.SetActive(false);
        scoreScript.textVarible = "score: " + score;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "basketball")
        {
            effectObject.SetActive(true);
            score = score + 1;
            scoreScript.textVarible = "score: "+score;    //set score script's textVariable to the score int as a string
            if(score == 3)          //if score is 3 
            {
                scoreScript.textVarible = "score: " + score;
                SceneManager.LoadScene(1);
            }
        }
    }
}
