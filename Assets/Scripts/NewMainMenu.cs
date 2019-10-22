using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewMainMenu : MonoBehaviour
{
    public GameObject Menumaster;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayGame(int sceneindex)
    {
        Debug.Log("Active Play button");
        SceneManager.LoadScene(sceneindex);
        Menumaster.SetActive(false);

    }

    public void Quit()
    {
        Debug.Log("QUIT GAME!");
        Application.Quit();

    }
}
