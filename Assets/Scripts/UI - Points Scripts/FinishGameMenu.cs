using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class FinishGameMenu : MonoBehaviour
{
    //Variable voor de attributesmanager van de Player (in Unity word deze ingesteld)
    public AttributesManager playerAtm;

    //Variable voor UI tekst en buttons voor game over of victory. (in dit geval voor game over)
    public string textValue;
    public TMP_Text textElement;
    public Button btnElement;
    public Button btnBackElement;

    //Meteen wanneer de game start gebeurt dit.
    void Awake() {
        //Tijd op normale snelheid, (reset voor restart.)
        Time.timeScale = 1.0f;
        //Player health op 100 zetten.
        playerAtm.health = 100;
        //UI start inactief, zodat het niet zichtbaar is aan het begin.
        textElement.text = textValue;
        textElement.gameObject.SetActive(false);
        btnElement.gameObject.SetActive(false);
        btnBackElement.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Tijd op normale snelheid, (reset voor restart.)
        Time.timeScale = 1.0f;
        //Player health op 100 zetten.
        playerAtm.health = 100;
        //UI start inactief, zodat het niet zichtbaar is aan het begin.
        textElement.text = textValue;
        textElement.gameObject.SetActive(false);
        btnElement.gameObject.SetActive(false);
        btnBackElement.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerAtm.health < 1)
        {
            //Console debug voor checken.
            Debug.Log("Game Over Test");
            //UI tekst naar game over zetten.
            textValue = "Game Over";
            textElement.text = textValue;
            //UI actief zetten.
            textElement.gameObject.SetActive(true);
            btnElement.gameObject.SetActive(true);
            btnBackElement.gameObject.SetActive(true);
            //Tijd op pauze zetten zodat er niet gespeeld meer kan worden.
            Time.timeScale = 0.0f;
            //gameOverText.text == "Victory Royale";
        }
    }
}
