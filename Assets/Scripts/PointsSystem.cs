using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class PointsSystem : MonoBehaviour
{
    public AttributesManager zombieAtm;

    public TMP_Text scoreText;

    public string scoreTextValue;

    public int scoreCount = 0;

    //public int addHundred = 100;

    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(zombieAtm.name + zombieAtm.isDead);
        zombieAtm.isDead = false;
        scoreCount = 0;
        //addHundred = 100;
        Score = scoreCount;
        //ZombieLength = GameObject.FindGameObjectsWithTag("zombie").Length;
    }

    // Update is called once per frame
    void Update()
    {

        if (zombieAtm.isDead == true) {
            scoreCount = scoreCount + 100;
            Score = scoreCount;
            //zombieAtm.isDead = false;
            Debug.Log(Score);
            Debug.Log(zombieAtm.isDead);
            return;
        } else {
            Score = scoreCount;
            Debug.Log(Score);
            Debug.Log(zombieAtm.isDead);
        }
        scoreTextValue = "Score: " + Score;
        scoreText.text = scoreTextValue;
        Debug.Log(Score);
    }
}
