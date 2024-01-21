using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//mo¿na siê odwo³¹æ do obiektów unity


public class obraz : MonoBehaviour
{
    void Start()
    {

    }
    public void OnTriggerEnter2D(Collider2D en)//funkcja wy³o³a siê gdy zajdzie interakcja
    {
        if (en.CompareTag("Player")) //jezeli obiekt z którym mamy interakcje ma tag Player to...
        {//za³adowuje nasz level na nowo
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}