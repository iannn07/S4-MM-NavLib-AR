using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void About()
    {
        SceneManager.LoadScene("AboutScene");
    }
    public void Back()
    {
        SceneManager.LoadScene("LoadingScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
