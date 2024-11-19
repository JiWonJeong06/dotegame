using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{   
    public static float distance;

    public static bool Gamestart;

    public static double Enregy = 100f;
    void Awake()
    {
        Gamestart = true;

        if (!PlayerPrefs.HasKey("Score")) {
            PlayerPrefs.SetFloat("Score", 0);
        }
    }
    void Update() {
         if (Gamestart) {
            distance += Time.deltaTime * 1f;
            Enregy -= Time.deltaTime * 1.2f;
            if (Enregy >= 100) {
                Enregy = 100f;
            }
            if (Enregy <= 0) {
                GameOver();
            }
         } 
    }

    public void GameOver() {
        Gamestart = false;
        float highdt = PlayerPrefs.GetFloat("Score");
        PlayerPrefs.SetFloat("Score", Mathf.Max(highdt, distance));

    }
    public void Restart() {
            distance = 0;
            Gamestart = true;
        }
    }
 

