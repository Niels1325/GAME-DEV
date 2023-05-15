using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class AttributesManager : MonoBehaviour
{
    //Health int aanmaken zodat we voor elk object health kunnen instellen
    public int health;
    //Attack damage int aanmaken zodat we voor elk object de attack damage kunnen instellen
    public int attackDamage;

    //public int prevScore = 0;
    //public int newScore = 0;
    //public int addHundred = 100;

    public bool isDead = false;

    //Meteen wanneer de game start word dit uitgevoerd.
    //void Awake()
    //{
        //Health van alles op 100 zetten.
        //health = 100;
    //}

    void Start()
    {
        //Health van alles op 100 zetten.
        health = 100;

        //Check of dood is op 0 zetten.
        isDead = false;
    }

    //functie om damage te krijgen
    public void TakeDamage(int amount)
    {
        //Health min het aantal attackdamage dat is ingesteld
        health -= amount;
    }

    //Functie voor het doen van damage
    public void DealDamage(GameObject target)
    {
        //Zoeken naar de attributesmanager
        var atm = target.GetComponent<AttributesManager>();
        //Als deze attributesmanager bestaat dan zorgt deze functie ervoor dat deze atm damage ontvangt.
        if(atm != null)
        {
            //Damage word gedaan doormiddel van de attackdamage dat is ingesteld in Unity.
            atm.TakeDamage(attackDamage);
        }
    }

    void Update()
    {
        //Als health onder 1 is word het object vernietigd uit de game.
        if(health <= 0) {
            isDead = true;
            Debug.Log(isDead);
            PointsSystem.PS.scoreCount += 100;
            Destroy(this.gameObject);
        } else
        {
            isDead = false;
        }
    }
}
