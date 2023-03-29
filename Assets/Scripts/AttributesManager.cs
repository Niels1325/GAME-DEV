using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    //Health int aanmaken zodat we voor elk object health kunnen instellen
    public int health;
    //Attack damage int aanmaken zodat we voor elk object de attack damage kunnen instellen
    public int attackDamage;

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
        if(health < 1)
        {
            Destroy(this.gameObject);
        }
    }
}
