using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{

    //Class voor NavMeshAgent (functie in Unity voor automatische beweging)
    NavMeshAgent nm;

    //Class voor waar dit object (zombie) heen moet lopen (in dit geval target aka player).
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //navmeshagent is de navmeshagent van de zombie.
        nm = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //Zet de bestemming waar de zombie heen moet lopen (dus de player)
        nm.SetDestination(target.position);
    }
}
