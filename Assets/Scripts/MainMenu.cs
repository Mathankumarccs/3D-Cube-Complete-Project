using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public static bool Playeractive = false;
    public GameObject PlayGameUI;
    public GameObject PlayMenuUI;
    public GameObject CompleteLevelUI;
    public GameObject ScoreBoardUI;
    public GameObject GroundUi;
    public GameObject GoldUI;
    public GameObject ScoreUI;
    public GameObject BlockUI;
    public GameObject GoldCoinUI;
    public GameObject RawimageUI;
    public GameObject ButtonClickUI;

    void Start()
    {
        PlayGameUI.SetActive(false);
        CompleteLevelUI.SetActive(false);
        ScoreBoardUI.SetActive(false);
        GroundUi.SetActive(false);
        GoldUI.SetActive(false);
        ScoreUI.SetActive(false);
        BlockUI.SetActive(false);
        GoldCoinUI.SetActive(false);
        
}

    public void PlayGame()
    {
        PlayGameUI.SetActive(true);
        Playeractive = true;
        PlayMenuUI.SetActive(false);
        //CompleteLevelUI.SetActive(true);
        //ScoreBoardUI.SetActive(true);
        GroundUi.SetActive(true);
        GoldUI.SetActive(true);
        ScoreUI.SetActive(true);
        BlockUI.SetActive(true);
        GoldCoinUI.SetActive(true);
        ButtonClickUI.SetActive(false);
        RawimageUI.SetActive(false);

    }

    public void Quit()
    {
        Debug.Log("QUIT GAME!");
        Application.Quit();

    }
    
    
}
