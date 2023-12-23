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
            print("Can Say�s�: " + PlayerPrefs.GetInt("canSayisi", 0));
            Debug.Log("Maalesef, can�n t�kendi. Oyun bitti!");
            // Oyunu durdurabilir veya ba�ka bir i�lem yapabilirsin.
            // �rne�in: Time.timeScale = 0;
        }
        else
        {
            PlayerPrefs.GetInt("canSayisi", 0);
            Debug.Log("A�a�la �arp��t�n! Bir can kaybettin. Kalan Can: " + canSayisi);
        }
    }

}
