using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public int points = 0;
	public Text pointsDisp;
    public float targetTime = 20.0f;
    public Text timeDisp;
    public Text gameOver;
    bool gameEnd = false;
    public GameObject retryButton;
    public GameObject quitButton;
	
	public void addPoints(int value) {
		points += value;
	}
    // Start is called before the first frame update
    void Start()
    {
        retryButton.SetActive(false);
        quitButton.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        pointsDisp.text = "Points: " + points;
        timeDisp.text = "Time: " + targetTime;

        if(targetTime <= 0.0f)
        {
            targetTime = 0;
            gameEnd = true;
        }

        if (gameEnd == true)
        {
            Time.timeScale = 0;
            gameOver.text = "You got " + points + " points!";
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            retryButton.SetActive(true);
            quitButton.SetActive(true);
        }

    }
}
