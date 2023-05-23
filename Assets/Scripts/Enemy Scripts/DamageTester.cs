using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    //Variable voor attributes manager van de Player (deze word in Unity ingesteld)
    public AttributesManager playerAtm;

    //Varibale voor attributes manager van de Enemy (deze word in Unity ingesteld)
    public AttributesManager enemyAtm;

    void Update()
    {
        //Zodra er op F11 word geklikt word deze functie uitgevoerd.
        if(Input.GetKeyDown(KeyCode.F11))
        {   
            //De Player krijgt het aantal damage dat in de enemy's attributes manager is ingesteld.
            playerAtm.DealDamage(enemyAtm.gameObject);
        }

        //Zodra er op F12 word geklikt word deze functie uitgevoerd.
        if(Input.GetKeyDown(KeyCode.F12))
        {
            //De Enemy krijgt het aantal damage dat in de player's attributes manager is ingesteld.
            enemyAtm.DealDamage(playerAtm.gameObject);
        }
    }
}
