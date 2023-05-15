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
    public static PointsSystem PS;
    private void Awake()
    {
        if (PS == null)
        {
            PS = this;

        }
        else
        {
            Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreCount = 0;
        scoreText.text = "Score " + 0;
        //addHundred = 100;
        Score = scoreCount;
        //ZombieLength = GameObject.FindGameObjectsWithTag("zombie").Length;
    }

    // Update is called once per frame
    void Update()
    {

       
        scoreTextValue = "Score: " + scoreCount;
        scoreText.text = scoreTextValue;
        Debug.Log(Score);
    }
}
