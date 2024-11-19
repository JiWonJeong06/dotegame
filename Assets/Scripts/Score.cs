using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{


    Text score_text;

    // Start is called before the first frame update
    void Start()
    {
        if(!GameManager.Gamestart){
            return;
        }
        score_text = GetComponent<Text>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!GameManager.Gamestart){
            return;}

        score_text.text = GameManager.score.ToString("F0") +" 점";
    }




}
