using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class AttributesManager : MonoBehaviour
{
    //Health int variable aanmaken zodat we voor elk object health kunnen instellen
    public int health;
    //Attack damage int variable aanmaken zodat we voor elk object de attack damage kunnen instellen
    public int attackDamage;

    void Start()
    {
        //Health van alles op 100 zetten.
        health = 100;
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
        //Als health onder 1 is word het object vernietigd uit de game en 100 punten toegevoegd aan score.
        if(health <= 0) {
            //Add 100 to score when zombie is dead
            PointsSystem.PS.scoreCount += 100;
            Destroy(this.gameObject);
        } else
        {
        }
    }
}
