using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

    int Gesamtpunkte = 0;
    public TextMesh Countertext;
    
    
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {


    }

    public void MehrPunkte(int Punkte)
    {
        Gesamtpunkte = Gesamtpunkte + Punkte;
        Countertext.text = Gesamtpunkte.ToString();
            }
     
}
