using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject zombiePrefab;

    public int amountOfZombiesPerRound = 10;

    public float timeBetweenRounds = 10f;

    private int waveNumber = 10;

    public Text gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRound());
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("zombie").Length == 0)
        {
            StartCoroutine(SpawnRound());
        }

        if (waveNumber == 10)
        {
            GameOver();
        }

    }

    void GameOver() 
    {
        //gameOverText.GetComponent<Text>().enabled = true;
        gameOverText.gameObject.SetActive(true);
        //gameOverText.text == "Victory Royale";
    }

    IEnumerator SpawnRound()    
    {
        waveNumber++;
        for (int i = 0; i < amountOfZombiesPerRound; i++)
        {
            Instantiate(zombiePrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

    
}
