using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool isInformationSceneOpen = false;

    public void Information()
    {
        if (!isInformationSceneOpen)
        {
            SceneManager.LoadScene("Information", LoadSceneMode.Additive);
            isInformationSceneOpen = true;
        }
        else
        {
            SceneManager.UnloadScene("Information");
            isInformationSceneOpen = false;
        }
    }

    public void ExitInformation()
    {
        if (!isInformationSceneOpen)
        {
            SceneManager.UnloadScene("Information");
            isInformationSceneOpen = false;
        }
    }
}
