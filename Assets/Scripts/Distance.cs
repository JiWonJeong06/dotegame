using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Distance : MonoBehaviour
{

    public bool ishighdt;

    float highdt;
    Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        if(!GameManager.Gamestart){
            return;
        }

        uiText = GetComponent<Text>();

        if (ishighdt) {
            highdt = PlayerPrefs.GetFloat("Score");
            uiText.text = highdt.ToString("F1") + " M";
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!GameManager.Gamestart){
            return;}
        
        if (ishighdt && GameManager.distance < highdt)
            return;
        
        uiText.text = GameManager.distance.ToString("F1") + " M";
    }
}
