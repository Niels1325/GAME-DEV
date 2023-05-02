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

    public int prevScore = 0;
    public int newScore = 0;
    public int addHundred = 100;

    public bool isDood = false;

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
        isDood = false;
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

    public void Add100(int fprevScore, int fnewScore, int faddHundred) {           
            fnewScore = fprevScore + faddHundred;
            newScore = fnewScore;
    }

    void Update()
    {
        //Als health onder 1 is word het object vernietigd uit de game.
        if(health <= 0) {
            isDood = true;
            Add100(prevScore, newScore, addHundred);
            Debug.Log(newScore);
            Debug.Log(prevScore);
            //Debug.Log(Score);
            Destroy(this.gameObject);
        }
    }
}
