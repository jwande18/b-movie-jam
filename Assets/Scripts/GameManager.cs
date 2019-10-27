using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public int points = 0;
	public Text pointsDisp;
	
	public void addPoints(int value) {
		points += value;
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointsDisp.text = "Points: " + points;
    }
}
