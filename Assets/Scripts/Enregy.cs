using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enregy : MonoBehaviour
{

    Text E_uiText;
    // Start is called before the first frame update
    void Start()
    {
         if(!GameManager.Gamestart){
            return;
        }

        E_uiText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.Gamestart){
            return;}

        E_uiText.text = "기력 " + GameManager.Enregy.ToString("F0");
    }
}
