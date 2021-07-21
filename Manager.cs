using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
    public void strtBtn()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitBtn()
    {
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Resume()
    {
        Time.timeScale = 1;
    }
    public void PauseBtn()
    {
        Time.timeScale = 0;
    }
    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
