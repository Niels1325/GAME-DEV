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

    public int scoreCount;

    public int addHundred;

    public int Score;

    public int prevScore;
    public int newScore;

    //public int scoreCount = 0;



    void Start() {
        isHit = 0;
        prevScore = 0;
        newScore = 0;
        addHundred = 100;
    
        //scoreText.text = scoreTextValue;
    }

    /*public void Add100() {
            Score = scoreCount + addHundred;
            Debug.Log(scoreTextValue);
    }*/

    //Zodra er collision is word deze functie uitgevoerd.
    void OnCollisionEnter(Collision coll)
    { 
        //Als er alleen collision is met de bullet (elk object met de tag "bullet") krijgt de zombie de damage aantal dat is ingesteld op de bullet.
        if(coll.gameObject.tag == "bullet")
        {
            isHit++;
            bulletAtm.DealDamage(zombieAtm.gameObject);
            //Debug.Log(isHit);

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
            //Debug.Log(" Player -10 " + "Current Player HP: " + playerAtm.health);
        }

        
    }

    

    void Update()
    {
        //newScore = prevScore + addHundred;
        //scoreText.text = scoreTextValue;
        if (isHit == 3) {
            //scoreTextValue = "Score: " + "" + newScore +"";
            //scoreTextValue = "Score: " + scoreCount + "";
            
        } else {
           //scoreTextValue = "Score: " + newScore;
        }
        
        prevScore = newScore;
        //scoreTextValue = "Score: " + Score;
        //scoreText.text = scoreTextValue;
        //Debug.Log(Score);
    }
}
