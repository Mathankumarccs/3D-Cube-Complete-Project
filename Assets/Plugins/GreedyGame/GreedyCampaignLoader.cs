using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using GreedyGame.Runtime;
using GreedyGame.Platform;
using GreedyGame.Runtime.Units;
using GreedyGame.Commons;

public class GreedyCampaignLoader : SingletoneBase<GreedyCampaignLoader>
{

    public List<string> unitList;

    public bool AdMobMediation = false;

    public bool MoPubMediation = false;

    public string GameId = "";

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (RuntimePlatform.Android == Application.platform || RuntimePlatform.IPhonePlayer == Application.platform)
        {
            GGAdConfig adConfig = new GGAdConfig();
            adConfig.setListener(new GreedyAgentListener());
            adConfig.setGameId(GameId);
            adConfig.enableAdmobMediation(AdMobMediation);
            adConfig.enableMopubMediation(MoPubMediation);
            adConfig.addUnitList(unitList);
            GreedyGameAgent.Instance.init(adConfig);
        }
        else
        {
            moveToNextScene();
        }
    }

    private static void moveToNextScene()
    {
        if (Application.loadedLevel == 0)
        {
            Application.LoadLevel(1);
        }
    }

    public class GreedyAgentListener : IAgentListener
    {

        public void onAvailable(string campaignId)
        {
            /**
         * TODO: New campaign is available and ready to use for the next scene.
         **/
            Debug.Log("GreedyAgentListener onAvailable");
            Debug.Log("======================================================");
            Debug.Log("==RGBA32" + " "+ SystemInfo.SupportsTextureFormat(TextureFormat.RGBA32));
            Debug.Log("==ARGB32" + " " + SystemInfo.SupportsTextureFormat(TextureFormat.ARGB32));
            Debug.Log("==DXT1Crunched" + " " + SystemInfo.SupportsTextureFormat(TextureFormat.DXT1Crunched));
            Debug.Log("==DXT5Crunched" + " " + SystemInfo.SupportsTextureFormat(TextureFormat.DXT5Crunched));
            Debug.Log("======================================================");

            moveToNextScene();
        }

        public void onUnavailable()
        {
            /**
         * TODO: No campaign is available, proceed with normal flow of the game.
         **/
            
            Debug.Log("GreedyAgentListener onUnavailable");
            Debug.Log("======================================================");
            Debug.Log("===" + SystemInfo.SupportsTextureFormat(TextureFormat.DXT1));
            Debug.Log("======================================================");
            moveToNextScene();
        }

        public void onError(string error)
        {
            /**
         * TODO: No Campaign will be served since the initialization resulted in an error. 
         * If device api level is below 15 this callback is invoked.
         **/
            Debug.Log("GreedyAgentListener onError");
            moveToNextScene();
        }

    }

}
