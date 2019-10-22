using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayAgain : MonoBehaviour
{

    // public static bool Playeractive = false;
    public GameObject PlayGameUI;
    public GameObject PlayMenuUI;
    public GameObject PlayAgainUI;
    public float restartDelay = 20f;

    public void Playgame()
    {
        float restartDelay1 = 0.1f;
        Invoke("Restart", restartDelay1);
        PlayGameUI.SetActive(false);
        //Playeractive = true;
        PlayMenuUI.SetActive(true);
        PlayAgainUI.SetActive(false);
        GoldScoreScript.coinAmount = 0;

    }
    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void Quit()
    {
        Debug.Log("QUIT GAME!");
        Application.Quit();

    }
}
