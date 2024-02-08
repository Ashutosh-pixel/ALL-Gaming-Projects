using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back()
    {
       SceneManager.LoadScene("Menu");
    }

public void detail()
{
    SceneManager.LoadScene("Menu 1");
}
    public void invertb()
    {
        SceneManager.LoadScene("Menu 2");
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();

    }

}
