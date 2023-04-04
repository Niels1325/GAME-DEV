using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    //Zombie prefab toevoegen zodat deze gespawned kan worden
    public GameObject zombiePrefab;

    //Het aantal zombies dat per ronde spawned.
    public int amountOfZombiesPerRound = 10;

    //Het tijd tussen rondes
    public float timeBetweenRounds = 10f;

    //Welke ronde je zit.
    private int waveNumber = 0;

    public string textValue;
    public TMP_Text textElement;

    //De spawnpoints toevoegen als array zodat ik random spawn points kan zetten.
    GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        textElement.text = textValue;
        //Spawnpoints zoeken doormiddel van tag
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnpoint");
        //Random spawnpoint.
        index = Random.Range(0, spawnPoints.Length);
        //De huidige spawnpoint
        currentPoint = spawnPoints[index];
        StartCoroutine(SpawnRound());
        //textElement.gameObject.SetActive(false);
        textElement.transform.LookAt(Camera.main.transform);
    }

    // Update is called once per frame
    void Update()
    {
        textElement.transform.LookAt(Camera.main.transform);
        //Constant zorgen dat de spawnpoint random is
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];

        //Als er 0 zombies zijn dan start er een nieuwe ronde.
        if (GameObject.FindGameObjectsWithTag("zombie").Length == 0)
        {
            StartCoroutine(SpawnRound());
        }

        //Als je bij ronde 10 bent finisht de game
        if (waveNumber == 10)
        {
            GameOver();
        }

    }

    void GameOver() 
    {
        //gameOverText.GetComponent<Text>().enabled = true;
        //gameOverText.gameObject.SetActive(true);
        Debug.Log("Game Over Test");
        //textElement.gameObject.SetActive(true);
        //gameOverText.text == "Victory Royale";
    }

    //Spawnround functie
    IEnumerator SpawnRound()    
    {
        //Ronde gaat omhoog
        waveNumber++;
        //Checkt of er geen zombies zijn dan spawnen er zombies.
        for (int i = 0; i < amountOfZombiesPerRound; i++)
        {
            //functie om de zombie te spawnen doormiddel van de prefab, rotatie en positie.
            Instantiate(zombiePrefab, currentPoint.transform.position, Quaternion.identity);
            //tijd tussen zombie spawn.
            yield return new WaitForSeconds(1f);
        }
    }

    
}
