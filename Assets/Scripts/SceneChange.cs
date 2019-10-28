using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class SceneChange : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    public void StartGame()
    {
            SceneManager.LoadSceneAsync("Game");
            Restart();
    }

    public void InfoCredits()
    {
        SceneManager.LoadSceneAsync("InfoCredits");
    }

    public void BackToTitle()
    {
        Restart();
        SceneManager.LoadSceneAsync("Title");

    }
}
