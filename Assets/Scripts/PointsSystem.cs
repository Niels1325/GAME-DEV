using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class PointsSystem : MonoBehaviour
{
    //UI Score text
    public TMP_Text scoreText;

    public string scoreTextValue;

    public int scoreCount = 0;

    //Static pointssystem singulator
    public static PointsSystem PS;

    //Wanneer de game start word dit gelijk uitgevoerd
    private void Awake()
    {
        if (PS == null)
        {
            PS = this;

        }
        else
        {
            //Wanneer er meer dan 1 puntensysteem is word deze verwijderd.
            Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //Zet score count op 0
        scoreCount = 0;
        scoreText.text = "Score " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Update de UI met de huidige score
        scoreTextValue = "Score: " + scoreCount;
        scoreText.text = scoreTextValue;
    }
}
