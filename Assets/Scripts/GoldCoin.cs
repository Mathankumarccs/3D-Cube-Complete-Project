using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoin : MonoBehaviour {

    

	private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Player"))
        {

            GoldScoreScript.coinAmount += 1;
          
            Destroy(gameObject);

        }
    }
}
