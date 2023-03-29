using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (coll.gameObject.tag == "player")
        {
            zombieAtm.DealDamage(playerAtm.gameObject);
            //Debug.Log(" Player -10 " + "Current Player HP: " + playerAtm.health);
        }
    }
}
