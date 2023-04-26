using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    //NavMeshAgent van zombie
    //public GameObject nmaZombie;

    //Zombie prefab toevoegen zodat deze gespawned kan worden
    public GameObject zombiePrefab;

    //Class voor de attributesmanager van de Zombie (in Unity word deze ingesteld)
    public AttributesManager zombieAtm;

    //Het aantal zombies dat per ronde spawned.
    public int amountOfZombiesPerRound = 10;

    //De tijd tussen rondes
    public float timeBetweenRounds = 10f;

    //Welke ronde je zit.
    private int waveNumber = 0;
    //public int scoreCount = 0;

    //UI (victory en game over tekst en button voor restart)
    public string textValue;
    public string roundTextValue;
    public TMP_Text textElement;
    public TMP_Text roundText;
    public Button btnElement;
    public Button btnBackElement;

    public bool EscapeMenuOpen = false;
    

    //De spawnpoints toevoegen als array zodat ik random spawn points kan zetten.
    GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;
    [SerializeField]
    //AnimationCurve spawnCurve;

    void Awake() {
        //Het aantal zombies dat per ronde spawned.
        amountOfZombiesPerRound = 10;
        //De tijd tussen rondes resetten
        timeBetweenRounds = 10f;
        //Round nummer op 1 zetten.
        waveNumber = 0;
        //UI inactief zetten, zodat het niet te zien is aan het begin.
        textElement.gameObject.SetActive(false);
        btnElement.gameObject.SetActive(false);
        btnBackElement.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        //nmaZombie = GetComponent<UnityEngine.AI.NavMeshAgent>().speed;
        //Round nummer op 1 zetten.
        waveNumber = 0;
        //De tekst wat het moet zijn.
        textElement.text = textValue;

        roundText.text = roundTextValue;
        //scoreText.text = scoreTextValue;

        //Round text
        roundTextValue = "Round: " + waveNumber;
        roundText.text = roundTextValue;
        //Score text
        //scoreTextValue = "Score: " + scoreCount;
        //scoreText.text = scoreTextValue;

        //Spawnpoints zoeken doormiddel van tag
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnpoint");
        //Random spawnpoint.
        index = Random.Range(0, spawnPoints.Length);
        //De huidige spawnpoint
        currentPoint = spawnPoints[index];
        //Start routine voor het spawnen van zombies.
        StartCoroutine(SpawnRound());
        //UI inactief zetten, zodat het niet te zien is aan het begin.
        textElement.gameObject.SetActive(false);
        btnElement.gameObject.SetActive(false);
        btnBackElement.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
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

        //Round text
        roundTextValue = "Round: " + waveNumber;
        roundText.text = roundTextValue;
        //Score text
        //scoreTextValue = "Score: " + scoreCount;
        //scoreText.text = scoreTextValue;


        //if (zombieAtm.health == 0) {
        //    scoreCount += 100;
        //    Debug.Log("test");
        //}
        if(Input.GetKeyDown(KeyCode.F1) && !EscapeMenuOpen){ 
        EscapeMenuOpen = true;
        //Console log om te checken.
        Debug.Log("Escape Menu");
        textValue = "Navigation";
        textElement.text = textValue;
        //Zet de ui actief.
        textElement.gameObject.SetActive(true);
        btnElement.gameObject.SetActive(true);
        btnBackElement.gameObject.SetActive(true);
        //De tijd op 0 zetten zodat alles op pauze staat.
        Time.timeScale = 0.0f;
        } else if (EscapeMenuOpen == true && Input.GetKeyDown(KeyCode.F1)) {
            EscapeMenuOpen = false;
            //UI inactief zetten.
            textElement.gameObject.SetActive(false);
            btnElement.gameObject.SetActive(false);
            btnBackElement.gameObject.SetActive(false);
            Time.timeScale = 1.0f;
        }

    }

    void GameOver() 
    {
        //Console log om te checken.
        Debug.Log("Victory Test");
        textValue = "Victory Royale";
        textElement.text = textValue;
        //Zet de ui actief.
        textElement.gameObject.SetActive(true);
        btnElement.gameObject.SetActive(true);
        btnBackElement.gameObject.SetActive(true);
        //De tijd op 0 zetten zodat alles op pauze staat.
        Time.timeScale = 0.0f;
    }

    //Spawnround functie
    IEnumerator SpawnRound()    
    {
        //Ronde gaat omhoog
        waveNumber++;
        amountOfZombiesPerRound++;
        //nmaZombie + 0.2f;
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
