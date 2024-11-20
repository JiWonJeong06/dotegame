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

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!GameManager.Gamestart){
            return;}
        uiText.text = GameManager.distance.ToString("F1") + " M";
    }
}
