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

    //class voor UI tekst en buttons voor game over of victory. (in dit geval voor game over)
    public string textValue;
    public TMP_Text textElement;
    public Button btnElement;

    //Meteen wanneer de game start gebeurt dit.
    void Awake()
    {
        //Tijd op normale snelheid, (reset voor restart.)
        Time.timeScale = 1.0f;
        //Player health op 100 zetten.
        playerAtm.health = 100;
        //UI start inactief, zodat het niet zichtbaar is aan het begin.
        textElement.text = textValue;
        textElement.gameObject.SetActive(false);
        btnElement.gameObject.SetActive(false);
    }

    void Start() {
        //Tijd op normale snelheid, (reset voor restart.)
        Time.timeScale = 1.0f;
        //Player health op 100 zetten.
        playerAtm.health = 100;
        //UI start inactief, zodat het niet zichtbaar is aan het begin.
        textElement.text = textValue;
        textElement.gameObject.SetActive(false);
        btnElement.gameObject.SetActive(false);
    }

    //Zodra er collision is word deze functie uitgevoerd.
    void OnCollisionEnter(Collision coll)
    { 
        //Als er alleen collision is met de bullet (elk object met de tag "bullet") krijgt de zombie de damage aantal dat is ingesteld op de bullet.
        if(coll.gameObject.tag == "bullet")
        {
            bulletAtm.DealDamage(zombieAtm.gameObject);
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

    void FixedUpdate()
    {
        if(playerAtm.health < 1)
        {
            //Console debug voor checken.
            Debug.Log("Game Over Test");
            //UI tekst naar game over zetten.
            textValue = "Game Over";
            textElement.text = textValue;
            //UI actief zetten.
            textElement.gameObject.SetActive(true);
            btnElement.gameObject.SetActive(true);
            //Tijd op pauze zetten zodat er niet gespeeld meer kan worden.
            Time.timeScale = 0.1f;
            //gameOverText.text == "Victory Royale";
        }
    }
}
