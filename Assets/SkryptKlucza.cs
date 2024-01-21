using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//dodajemy do obs³ugi tekstu
public class SkryptKlucza : MonoBehaviour
{
    public Text wynik;//aby daæ obiekt tekstu naszego do wyœwietlenia 
    private int score;
    void Start()
    {
        score = 0;
        wynik.text = "Score:" + score.ToString();//dodanie wyniku do obiektu Unity
    }
    public void OnTriggerEnter2D(Collider2D klucz)//funkcja wy³o³a siê gdy zajdzie interakcja
    {
        if(klucz.tag == "Key") //jezeli obiekt z którym mamy interakcje ma tak Key to ...
        {
            score += 10;//wieksza siê nasz wynik
            Destroy(klucz.gameObject);//i niszczony jest ten obiekt
    wynik.text = "Score:" + score.ToString();
        }
    }
}