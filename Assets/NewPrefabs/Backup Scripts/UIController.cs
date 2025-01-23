using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Pause()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
    public void Exit()
    {
        Debug.Log("Exit The Game");
        Application.Quit();
    }
        
    
    
}
