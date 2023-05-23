using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    //Variable voor de gezette vuurpunt (vanaf waar de bullets moeten spawnen)
    public Transform firePoint;

    //Variable voor het object van de bullet (de bullet materials en de bullet zelf) (Bullet Prefab)
    public GameObject bulletPrefab;

    //Snelheid van de bullet
    public float bulletForce = 200f;

    //Variable voor het richten
    private Vector3 aim;

    //Variable voor de rigidbody van de bullet
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        //Als er op linker muis knop word gedrukt word de functie Shoot() uitgevoerd.
        if(Input.GetButtonDown("Fire1")) {
            Shoot();
        }


        //Camera is de main camera
        Camera cam = Camera.main;

        //Muis positie is muis input. (zorgt ervoor dat de muis word herkent en waar de muis is/richt)
        Vector3 mousePos = Input.mousePosition;

        //Aim is de muis converted naar waar de muis op de grond zou zijn.
        aim = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
    }

    void Shoot() 
    {
        //Hierdoor kijkt het vuurpunt naar de aim (dus waar je muis is)
        firePoint.transform.LookAt(aim);
        //bullet instance word aangemaakt wat betekent dat de bullet spawned op basis van de vuurpunt, positie en rotatie. en gebruikt dus de bullet prefab.
        var instance = Instantiate(bulletPrefab, firePoint.transform.position, firePoint.rotation);
        //Zorgt ervoor dat de instance ook kijkt waar de muis is.
        instance.transform.LookAt(aim);
        //instance pakt de rigidbody van de player en voegt het snelheid toe van de bullet.
        instance.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * bulletForce, ForceMode.Impulse);   
    }

    
}
