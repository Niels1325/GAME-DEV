using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class StartGame : MonoBehaviour
{
    public int gameStartGame;

    // Update is called once per frame

    //Deze functie word gerunt wanneer je op de knop Start drukt in de Main Menu
    public void StartTheGame()
    {
        //Hiermee word de GamePlay Scene gestart
        SceneManager.LoadScene(gameStartGame);
    }
}
