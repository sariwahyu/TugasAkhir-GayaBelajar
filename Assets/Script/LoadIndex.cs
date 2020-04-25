using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadIndex : MonoBehaviour
{
    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
    public void SceneLoaderString(string SceneString)
    {
        SceneManager.LoadScene(SceneString);
    }
    public void ExitApp()
    {
        Application.Quit();
    }
}
