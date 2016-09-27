using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public int score;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        UpdateScore();
	}

    void UpdateScore()
    {
        GameObject cam = GameObject.Find("Main Camera");
        DraggingScript camScript = cam.GetComponent<DraggingScript>();
        score = (int) camScript.score;
        scoreText.text = "Score: " + score;
    }
}
