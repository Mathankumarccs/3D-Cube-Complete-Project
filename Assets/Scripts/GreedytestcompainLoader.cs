using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using GreedyGame.Runtime;
using GreedyGame.Platform;
using GreedyGame.Runtime.Units;
using GreedyGame.Commons;

public class GreedytestcompainLoader : MonoBehaviour
{

    public List<string> Unit;

    public bool Admob = false;

    public bool Mppub = false;

    public string GameId = "";

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (RuntimePlatform.Android == Application.platform || RuntimePlatform.IPhonePlayer == Application.platform)
        {
            GGAdConfig con = new GGAdConfig();
            con.setListener(new AgentListener());
            con.setGameId(GameId);
            con.enableAdmobMediation(Admob);
            con.enableMopubMediation(Mppub);
            con.addUnitList(Unit);
            GreedyGameAgent.Instance.init(con);
            
        }
        else
        {
            Debug.Log("UnityGG Platform is not Found");
            Movenext();
        }
    }
    private static void Movenext()
    {
        if (Application.loadedLevel == 0)
        {
            Application.LoadLevel(1);
        }
    }

    public class AgentListener : IAgentListener
    {

        public void onAvailable(string campaignId)
        {
            /**
         * TODO: New campaign is available and ready to use for the next scene.
         **/
            Debug.Log("GreedyAgentListener onAvailable");
            //Movenext();
        }

        public void onUnavailable()
        {
            /**
         * TODO: No campaign is available, proceed with normal flow of the game.
         **/
            Debug.Log("GreedyAgentListener onUnavailable");
            Movenext();
        }

        public void onError(string error)
        {
            /**
         * TODO: No Campaign will be served since the initialization resulted in an error. 
         * If device api level is below 15 this callback is invoked.
         **/
            Debug.Log("GreedyAgentListener onError");
            Movenext();

            //TODO OOP Concepts
            //Mathan myObjectThousandFactor = new Mathan(1000);
            //Mathan myObjectTenObject = new Mathan(10);
            //myObjectTenObject.Multiplier(9);
            //myObjectThousandFactor.Multiplier(2);

        }

    }
}
