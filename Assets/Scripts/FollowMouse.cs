using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    //Rigidbody zoeken van de player.
    private Rigidbody rb;

    //Class voor de camera
    private Camera mainCamera;

    void Start()
    {
        //Rigidbody is rigidbody van de player
        rb = GetComponent<Rigidbody>();

        //mainCamera is de camera
        mainCamera = FindObjectOfType<Camera>();
    }

    void FixedUpdate()
    {
        //Dit zorgt ervoor dat je muis pointer word geconvert naar een soort laser ray beam en hierdoor weet de game correct waar je muis is op de groundlevel.
        Ray CameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        //Als de muis te vinden is op de groundlevel word dit uitgevoerd.
        if (groundPlane.Raycast(CameraRay, out rayLength)) {

            //Class aanmaken voor waar de player naar moet kijken.
            Vector3 pointToLook = CameraRay.GetPoint(rayLength);

            //Voor het debuggen als je de game op pauze zet zie je waar je muis werkelijk is en hoe dit in zijn werking gaat.
            Debug.DrawLine(CameraRay.origin, pointToLook, Color.blue);

            //De player kijkt naar waar de muis is via de laser ray beam ding.
            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }


}
