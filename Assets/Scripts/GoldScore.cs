using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldScore : MonoBehaviour {

    
    public Text Gtext;

    // Use this for initialization
    void Update()
    {
        Gtext.text = GoldScoreScript.coinAmount.ToString();
       
    }

}
