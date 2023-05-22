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
    public void StartTheGame()
    {
        SceneManager.LoadScene(gameStartGame);
    }
}
