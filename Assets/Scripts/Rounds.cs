using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rounds : MonoBehaviour
{

    public float roundNr = 1;
    public float killCount = 0;

    public GameObject zombie;

    // Start is called before the first frame update
    void Start()
    {
        if(zombie == null)
        {
            Debug.Log("1 dood");
        } else
        {
            Debug.Log("allemaal niet dood");
        }
    }

    void EndGame()
    {
        Debug.Log("W Winner");
    }

    // Update is called once per frame
    void Update()
    {

        if(killCount == 10)
        {
            roundNr = 2;
        } else if(killCount == 20)
        {
            roundNr = 3;
        } else if(killCount == 30)
        {
            roundNr = 4;
        } else if(killCount == 40)
        {
            roundNr = 5;
        } else if(killCount == 50)
        {
            roundNr = 6;
        }
        else if(killCount == 60)
        {
            roundNr = 7;
        } else if(killCount == 70)
        {
            roundNr = 8;
        } else if(killCount == 80)
        {
            roundNr = 9;
        }
        else if(killCount == 90)
        {
            roundNr = 10;
        } else if(killCount == 100)
        {
            roundNr = 10;
            EndGame();
        } 
    }
}
