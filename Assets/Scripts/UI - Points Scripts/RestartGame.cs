using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    //Een variable voor de main menu scene
    public int mainMenu;

    //Deze functie word gerunt wanneer je op de Restart button drukt in de volgende schermen: Escape/navigation (F1) scherm, Game Over scherm en Victory scherm.
    public void RestartTheGame()
    {
        //Dit zorgt ervoor dat de huidige scene zich reload en de game opnieuw gespeeld kan worden.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //Deze functie word gerunt zodra er op de Back To Main Menu button word gedrukt.
    public void BackToMainMenu()
    {
        //Dit zorgt ervoor dat de Main Menu Scene geladen word.
        SceneManager.LoadScene(mainMenu);
    }
}
