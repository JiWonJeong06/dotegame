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

    public static float score;

    public static float TotalScore;

    public static float bbangeo;
    public static float ggajami;
    public static float ddomi;
    public static float ccalamari;
    public static float ttuna;

    public GameObject mainui;
    public GameObject gameoverui;
    public GameObject guidebook;
    public GameObject sstartui;
    public void sstart(){
        Gamestart = true;
        sstartui.SetActive(true);
        mainui.SetActive(false);
    }
    public void Guide() {
        guidebook.SetActive(true);
        mainui.SetActive(false);
    }
        public void ReGuide() {
        guidebook.SetActive(false);
        mainui.SetActive(true);
    }
    public void mmain(){
    
            distance = 0;
            score = 0;
            bbangeo = 0;
            ggajami = 0;
            ddomi = 0;
            ccalamari =0;
            ttuna = 0;
            Enregy = 100f;
            gameoverui.SetActive(false);
            mainui.SetActive(true);
            sstartui.SetActive(false);
    }
    void Awake()
    {
        if (!PlayerPrefs.HasKey("Score")) {
            PlayerPrefs.SetFloat("Score", 0);
        }
    }
    void Update() {
         if (Gamestart) {
            distance += Time.deltaTime * 1f;
            Enregy -= Time.deltaTime * 1.25f;
            
            if (Enregy >= 100) {
                Enregy = 100f;
            }
         } 
    }

    public void GameOver() {
        Gamestart = false;
        gameoverui.SetActive(true);
        float highscore = PlayerPrefs.GetFloat("Score");
        PlayerPrefs.SetFloat("Score", Mathf.Max(highscore, score));

    }
    public void Restart() {
            SceneManager.LoadScene(0);
            distance = 0;
            score = 0;
            bbangeo = 0;
            ggajami = 0;
            ddomi = 0;
            ccalamari =0;
            ttuna = 0;
            Enregy = 100f;

        }
    }
 

