using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{

    //Class voor het Object van de bullet (deze word in Unity ingesteld)
    public GameObject Bullet;

    //Zodra de bullet collision heeft word de bullet vernietigd uit de game.
    public void OnCollisionEnter (Collision collision) {
            Destroy (gameObject);           
    }
}
