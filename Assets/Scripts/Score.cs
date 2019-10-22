
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public Text MainScore;
    public static string Displayscore;

	void Update () {

        scoreText.text= player.position.z.ToString("0");
        MainScore.text = scoreText.text;
        //Displayscore = scoreText.ToString();

    }
}
 