using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//dziêki temu mo¿emy siê odwo³aæ do sceny
public class reset : MonoBehaviour
{
    void Start()
    {

    }
    public void ResetGame()
    {
        //s³u¿y do zresetowania/prze³adowania naszego poziomu
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}