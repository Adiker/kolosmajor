using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//mo�na si� odwo��� do obiekt�w unity


public class obraz : MonoBehaviour
{
    void Start()
    {

    }
    public void OnTriggerEnter2D(Collider2D en)//funkcja wy�o�a si� gdy zajdzie interakcja
    {
        if (en.CompareTag("Player")) //jezeli obiekt z kt�rym mamy interakcje ma tag Player to...
        {//za�adowuje nasz level na nowo
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}