using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager { get; private set; }

    //public Text round;

    private float fadeTime;
    private bool fadingIn;

    void Awake()
    {
        //MyGameObject.GetComponent<GameManager>().enabled = true;
        //MyGameObject.GetComponent<AttributesManager>().enabled = true;
        //MyGameObject.GetComponent<BulletDamage>().enabled = true;
        //MyGameObject.GetComponent<DestroyBullet>().enabled = true;
        //MyGameObject.GetComponent<DamageTester>().enabled = true;
        //MyGameObject.GetComponent<FollowMouse>().enabled = true;
        //MyGameObject.GetComponent<FollowPlayer>().enabled = true;
        //MyGameObject.GetComponent<PlayerController>().enabled = true;
        //MyGameObject.GetComponent<RestartGame>().enabled = true;
        //MyGameObject.GetComponent<RoundSpawnSystem>().enabled = true;
        //MyGameObject.GetComponent<Shooting>().enabled = true;
        //MyGameObject.GetComponent<ZombieAI>().enabled = true;
        //MyGameObject.GetComponent<Spawner>().enabled = true;
        //if (gameManager != null && gameManager != this)
        //{
        //    Destroy(this);
        //}
        //else
        //{
        //    gameManager = this;
        //}
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
