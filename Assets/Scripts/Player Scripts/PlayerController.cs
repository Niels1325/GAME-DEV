using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variable voor rigidbody van de player
    Rigidbody rb;

    //Snelheid van het bewegen van de player
    [SerializeField] float movementSpeed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        //De component rigidbody van de player pakken en deze word rb genoemd
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Zorgt ervoor dat zodra je A of D (pijltjes werken ook) klikt je naar links of rechts gaat (functie dat in Unity zit)
        float horizontalInput = Input.GetAxis("Horizontal");
        //Zorgt ervoor dat zodra je W of S (pijltjes werken ook) klikt je naar boven of onder gaat (functie dat in Unity zit)
        float verticalInput = Input.GetAxis("Vertical");

        //Zorgt ervoor dat de rigidbody via de de knoppen beweging kan maken doormiddel van gezette movementspeed (beweeg snelheid)
        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
    }

}

