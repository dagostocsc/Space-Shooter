using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject Option;

    public void playGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

  public void QuitGame()
    {
        Application.Quit();
    }

}
