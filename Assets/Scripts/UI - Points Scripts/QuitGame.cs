using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Start is called before the first frame update

    //Deze functie word gecalled wanneer je op quit drukt in de main menu.
    public void QuitTheGame()
    {
        //Dit zorgt ervoor dat de game word afgesloten (werkt alleen in de full build)
        Application.Quit();
    }
}
