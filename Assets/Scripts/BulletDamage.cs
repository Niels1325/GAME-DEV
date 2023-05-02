using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class BulletDamage : MonoBehaviour
{
    //Class voor de attributesmanager van de Zombie (in Unity word deze ingesteld)
    public AttributesManager zombieAtm;

    //Class voor de attributesmanager van de Bullet (in Unity word deze ingesteld)
    public AttributesManager bulletAtm;

    //Class voor de attributesmanager van de Player (in Unity word deze ingesteld)
    public AttributesManager playerAtm;

    //Class voor het object van de Bullet (in Unity word deze ingesteld)
    public GameObject bullet;

    public TMP_Text scoreText;

    public string scoreTextValue;

    public int isHit = 0;

    public int scoreCount = 0;

    public int addHundred = 100;

    public int Score;

    //public int scoreCount = 0;



    void Start() {
        isHit = 0;
        scoreCount = 0;
        addHundred = 100;
        //scoreText.text = scoreTextValue;
        //Score = 0;
    }

    public void Add100() {
            Score = scoreCount + addHundred;
    }

    //Zodra er collision is word deze functie uitgevoerd.
    void OnCollisionEnter(Collision coll)
    { 
        //Als er alleen collision is met de bullet (elk object met de tag "bullet") krijgt de zombie de damage aantal dat is ingesteld op de bullet.
        if(coll.gameObject.tag == "bullet")
        {
            isHit++;
            bulletAtm.DealDamage(zombieAtm.gameObject);
            Debug.Log(isHit);

        }  else
        {
            //Debug.Log(coll + " test");
        }
    }

    //Elke keer wanneer er collision is en deze blijft word deze functie uitgevoerd.
    void OnCollisionStay(Collision coll)
    {
        //Als er alleen collision is met de player krijgt deze player het aantal damage van de zombie atm.
        if (coll.gameObject.tag == "playertransform")
        {
            zombieAtm.DealDamage(playerAtm.gameObject);
            Debug.Log(" Player -10 " + "Current Player HP: " + playerAtm.health);
        }

        
    }

    void Update()
    {
        //scoreText.text = scoreTextValue;
        if (isHit >= 3) {
            Add100();
            scoreTextValue = "Score: " + Score;
            //scoreTextValue = "Score: " + scoreCount + "";
            isHit = 0;
            Debug.Log(scoreTextValue);
        } else {
           scoreTextValue = "Score: " + Score;
        }
        //scoreTextValue = "Score: " + Score;
        //scoreText.text = scoreTextValue;
        //Debug.Log(Score);
    }
}
