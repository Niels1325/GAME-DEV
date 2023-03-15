using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager { get; private set; }

    //public Text round;

    private float fadeTime;
    private bool fadingIn;

    void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
    }

    void Start(){
    //    round.CrossFadeAlpha(0, 0.0f, false);
    //    fadeTime = 0;
    //    fadingIn = false;
    }

    //void FadeIn()
    //{
    //    round.CrossFadeAlpha(1, 0.5f, false);
    //    fadeTime += Time.deltaTime;
    //    if(round.color.a == 1 && fadeTime > 1.5f)
    //    {
    //        fadingIn = false;
    //        fadeTime = 0;
    //    }
    //}
}
