using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    //Variable voor de rigidbody van de player.
    private Rigidbody rb;

    //Variable voor de camera
    private Camera mainCamera;

    void Start()
    {
        //De component rigidbody van de player pakken en deze word rb genoemd
        rb = GetComponent<Rigidbody>();

        //De camera van de scene als mainCamera
        mainCamera = FindObjectOfType<Camera>();
    }

    void FixedUpdate()
    {
        //Dit zorgt ervoor dat je muis pointer word geconvert naar een raycast beam line en hierdoor weet de game correct waar je muis is op de groundlevel.
        Ray CameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        //Als de muis te vinden is op de groundlevel word dit uitgevoerd.
        if (groundPlane.Raycast(CameraRay, out rayLength)) {

            //Variable aanmaken voor waar de player naar moet kijken.
            Vector3 pointToLook = CameraRay.GetPoint(rayLength);

            //Voor het debuggen als je de game op pauze zet zie je waar je muis werkelijk is en hoe dit in zijn werking gaat. (in het blauw)
            Debug.DrawLine(CameraRay.origin, pointToLook, Color.blue);

            //De player kijkt naar waar de muis is via de raycast.
            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }


}
