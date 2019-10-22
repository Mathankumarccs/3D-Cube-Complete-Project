using System.Collections;
using System.Collections.Generic;
using GreedyGame.Runtime;
using UnityEngine;
using UnityEngine.Advertisements;



public class AdsRefresh : MonoBehaviour
{
    public int Running = 1;
    public int second;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Running==1)
        {
            StartCoroutine(wait());
        }
    }

    public IEnumerator wait()
    {

        Running = 0;
        yield return new WaitForSeconds(second);
        //Debug.Log("Ads Refresh");
        GreedyGameAgent.Instance.startEventRefresh();
        Running = 1;
       
    }
}
