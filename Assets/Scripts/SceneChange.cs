using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        Restart();
    }

    public void InfoCredits()
    {
        SceneManager.LoadScene("InfoCredits");
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
