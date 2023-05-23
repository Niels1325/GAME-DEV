using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    //Variable voor player's positie/status (word in Unity ingesteld)
    public Transform player;


    void Start() {
        //Zorgt ervoor dat de camera de players positie volgt op een afstand van 10 op de y as. (hoogte in)
        transform.position = player.transform.position + new Vector3(0, 10, 0);
    }


    // Update is called once per frame
    void Update () {
        //Zorgt ervoor dat de camera de players positie volgt op een afstand van 10 op de y as. (hoogte in)
        transform.position = player.transform.position + new Vector3(0, 10, 0);
    }
}