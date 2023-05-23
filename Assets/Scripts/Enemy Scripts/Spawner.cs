using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    //Variable van de zombie prefab toevoegen zodat deze gespawned kan worden
    public GameObject zombiePrefab;

    //Variable voor de attributesmanager van de Zombie (in Unity word deze ingesteld)
    public AttributesManager zombieAtm;

    //Het aantal zombies dat per ronde spawned.
    public int amountOfZombiesPerRound = 10;

    //De tijd tussen rondes
    public float timeBetweenRounds = 10f;

    //Welke ronde je zit. (ronde counter)
    private int waveNumber = 0;

    //UI (victory en game over tekst en buttons voor restart en back to main menu)
    public string textValue;
    public string roundTextValue;
    public TMP_Text textElement;
    public TMP_Text roundText;
    public Button btnElement;
    public Button btnBackElement;

    //Variable bool voor het toggelen van de escape/navigation menu.
    public bool EscapeMenuOpen = false;
    

    //De spawnpoints toevoegen als array zodat ik random spawn points kan zetten.
    GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;
    [SerializeField]

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
        //Round nummer op 1 zetten.
        waveNumber = 0;
        //De tekst van textElement(UI TMP element) word gepakt van textValue(string).
        textElement.text = textValue;
        //De tekst van roundText(UI TMP element van de round text) word gepakt van roundTextValue(string).
        roundText.text = roundTextValue;

        //RoundTextValue word Round: de nummer van de huidige round
        roundTextValue = "Round: " + waveNumber;
        roundText.text = roundTextValue;

        //Spawnpoints zoeken doormiddel van de tag "spawnpoint" (deze zijn aangegeven in Unity)
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnpoint");
        //index is random nummer tussen het aantal spawnpoints. (Zodat de via de update function we tussen de spawnpoints kan cyclen en de zombie's steeds randomly spawnen tussen random spawnpoints)
        index = Random.Range(0, spawnPoints.Length);
        //De huidige spawnpoint is index
        currentPoint = spawnPoints[index];
        //Start de coroutine functie voor het spawnen van zombies.
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
            //Start de coroutine functie voor het spawnen van zombies.
            StartCoroutine(SpawnRound());
        }

        //Als je bij ronde 10 (wavenumer == 10) bent word deze functie uitgevoerd
        if (waveNumber == 10)
        {
            //Victory functie word uitgevoerd
            VictoryRoyale();
        }

        //Round text
        roundTextValue = "Round: " + waveNumber;
        roundText.text = roundTextValue;

        //Navigation/escape menu (F1), zodra er op F1 word gedrukt en de menu nog niet open is word de navigation menu geopend.
        if(Input.GetKeyDown(KeyCode.F1) && !EscapeMenuOpen){
        //Het Menu is open is true
        EscapeMenuOpen = true;

        //Console log voor debugging.
        //Debug.Log("Escape Menu");

        //De UI Title Text naar Navigation veranderen.
        textValue = "Navigation";
        //UI text gebruikt string van textValue
        textElement.text = textValue;

        //Zet de ui actief.
        textElement.gameObject.SetActive(true);
        btnElement.gameObject.SetActive(true);
        btnBackElement.gameObject.SetActive(true);
        //De tijd op 0 zetten zodat alles op pauze staat.
        Time.timeScale = 0.0f;
        } 
        //Als het menu open is en er word op F1 gedrukt sluit het menu weer doormiddel van deze functies hieronder
        else if (EscapeMenuOpen == true && Input.GetKeyDown(KeyCode.F1)) {
            //Zet de escapemenu bool op false, omdat het menu nu weer gesloten is.
            EscapeMenuOpen = false;
            //UI inactief zetten.
            textElement.gameObject.SetActive(false);
            btnElement.gameObject.SetActive(false);
            btnBackElement.gameObject.SetActive(false);
            //Tijd weer op 1.0f zetten, zodat de game weer doorgaat en op normale snelheid zit.
            Time.timeScale = 1.0f;
        }

    }

    //Game Over functie
    void VictoryRoyale() 
    {

        //Console log voor debugging
        //Debug.Log("Victory Test");

        //De UI Title Text naar Victory Royale veranderen.
        textValue = "Victory Royale";
        //UI text gebruikt string van textValue
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
        //Ronde nummer gaat omhoog
        waveNumber++;
        //Nummer van hoeveel zombies er per ronde zijn gaat omhoog
        amountOfZombiesPerRound++;
        //Checkt of er geen zombies zijn en zo niet dan spawnen er nieuwe zombies.
        for (int i = 0; i < amountOfZombiesPerRound; i++)
        {
            //functie om de zombie te spawnen doormiddel van de prefab, positie en rotatie.
            Instantiate(zombiePrefab, currentPoint.transform.position, Quaternion.identity);
            //tijd tussen elke zombie spawn coroutine.
            yield return new WaitForSeconds(1f);
        }
    }

    
}
