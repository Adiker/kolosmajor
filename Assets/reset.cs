using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//dzi�ki temu mo�emy si� odwo�a� do sceny
public class reset : MonoBehaviour
{
    void Start()
    {

    }
    public void ResetGame()
    {
        //s�u�y do zresetowania/prze�adowania naszego poziomu
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}