using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpismaKontrolleri : MonoBehaviour
{

    public int canSayisi = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Agac")
        {
            CarpismaIslemi();
        }
    }

    private void CarpismaIslemi()
    {
        canSayisi--;
        PlayerPrefs.SetInt("CanSayisi", canSayisi);
        if (canSayisi <= 0)
        {
            print("Can Sayýsý: " + PlayerPrefs.GetInt("canSayisi", 0));
            Debug.Log("Maalesef, canýn tükendi. Oyun bitti!");
            // Oyunu durdurabilir veya baþka bir iþlem yapabilirsin.
            // Örneðin: Time.timeScale = 0;
        }
        else
        {
            PlayerPrefs.GetInt("canSayisi", 0);
            Debug.Log("Aðaçla çarpýþtýn! Bir can kaybettin. Kalan Can: " + canSayisi);
        }
    }

}
