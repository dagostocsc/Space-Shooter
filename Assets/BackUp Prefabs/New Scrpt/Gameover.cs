using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    [SerializeField] GameObject GameOvermenu;

    public void Pause()
    {
        GameOvermenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        GameOvermenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Options()
    {

    }


    public void Quit()
    {
        Application.Quit();
    }


}
