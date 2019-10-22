using System.Collections;
using System.Collections.Generic;
using GreedyGame.Runtime;
using UnityEngine;

public class PopUpScript : MonoBehaviour
{

    void OnMouseDown()
    {

        GreedyGameAgent.Instance.showEngagementWindow("float-4100");

    }

   public void Buttonclick()
    {
        GreedyGameAgent.Instance.showEngagementWindow("float-4100");
    }
}
