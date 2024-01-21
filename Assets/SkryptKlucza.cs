using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//dodajemy do obs�ugi tekstu
public class SkryptKlucza : MonoBehaviour
{
    public Text wynik;//aby da� obiekt tekstu naszego do wy�wietlenia 
    private int score;
    void Start()
    {
        score = 0;
        wynik.text = "Score:" + score.ToString();//dodanie wyniku do obiektu Unity
    }
    public void OnTriggerEnter2D(Collider2D klucz)//funkcja wy�o�a si� gdy zajdzie interakcja
    {
        if(klucz.tag == "Key") //jezeli obiekt z kt�rym mamy interakcje ma tak Key to ...
        {
            score += 10;//wieksza si� nasz wynik
            Destroy(klucz.gameObject);//i niszczony jest ten obiekt
    wynik.text = "Score:" + score.ToString();
        }
    }
}