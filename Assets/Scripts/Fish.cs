using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fish : MonoBehaviour
{

    public bool Bangeo;
    public bool Gajami;
    public bool Domi;
    public bool Calamari;
    public bool Tuna;
    Text TBangeo;
    Text TGajami;
    Text TDomi;
    Text TCalamari;
    Text TTuna;



    // Start is called before the first frame update
    void Start()
    {
        if(!GameManager.Gamestart){
            return;
        }
        TBangeo = GetComponent<Text>();
        TGajami = GetComponent<Text>();
        TDomi = GetComponent<Text>();
        TCalamari = GetComponent<Text>();
        TTuna = GetComponent<Text>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!GameManager.Gamestart){
            return;}

        if(Bangeo) {
            TBangeo.text = "x " + GameManager.bbangeo.ToString("F0");
        }
        if(Gajami) {
            TGajami.text = "x " + GameManager.ggajami.ToString("F0");
        }
        if(Domi) {
            TDomi.text = "x " + GameManager.ddomi.ToString("F0");
        }
        if(Calamari) {
            TCalamari.text = "x " + GameManager.ccalamari.ToString("F0");
        }
        if(Tuna) {
            TTuna.text = "x " + GameManager.ttuna.ToString("F0");
        }       
    }
}
