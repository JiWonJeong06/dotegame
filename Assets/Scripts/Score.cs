using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{


    Text score_text;

    public bool TotalScoreText;

    public float TotalScore;

    // Start is called before the first frame update
    void Start()
    {
        if(!GameManager.Gamestart){
            return;
        }
        score_text = GetComponent<Text>();

        if(TotalScoreText) {
            TotalScore = PlayerPrefs.GetFloat("Score");
            score_text.text = TotalScore.ToString("F0") + " 점";
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!GameManager.Gamestart){
            return;}
          if (TotalScoreText && GameManager.score < TotalScore)
            return;
        
        score_text.text = GameManager.score.ToString("F0") +" 점";
    }




}
