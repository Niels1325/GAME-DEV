using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class BulletDamage : MonoBehaviour
{
    //Variable voor de attributesmanager van de Zombie (in Unity word deze ingesteld)
    public AttributesManager zombieAtm;

    //Variable voor de attributesmanager van de Bullet (in Unity word deze ingesteld)
    public AttributesManager bulletAtm;

    //Variable voor de attributesmanager van de Player (in Unity word deze ingesteld)
    public AttributesManager playerAtm;

    //Variable voor het object van de Bullet (in Unity word deze ingesteld)
    public GameObject bullet;

    void Start() {
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
        }
    }

    //Elke keer wanneer er collision is en deze blijft word deze functie uitgevoerd.
    void OnCollisionStay(Collision coll)
    {
        //Als er alleen collision is met de player (elk object met de tag "playertransform") krijgt deze player het aantal damage van de zombie attributes manager.
        if (coll.gameObject.tag == "playertransform")
        {
            zombieAtm.DealDamage(playerAtm.gameObject);
        }     
    }

    void Update()
    {
    }
}
