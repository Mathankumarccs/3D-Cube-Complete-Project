using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldScoreScript : MonoBehaviour {
    Text Text;
    public static int coinAmount;
    public static int Cointcount = 0;
    public  Text TotalGold;

    void Start()
    {
        Text = GetComponent<Text>();
    }

    void Update()
    {
        Text.text = coinAmount.ToString();
        //Cointcount = GoldScoreScript.coinAmount;
        TotalGold.text = coinAmount.ToString();
    }
	
}
