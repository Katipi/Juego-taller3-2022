using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;


    private void Awake()
    {
        manager = this;     
    }


    public void GameOver()
    {
        print("gameover"); 

    }


    public void WinGame()
    {

    }


    public void ResetearJuego()
    {


    }
}
