using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  public void Menubutton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Playbutton()
    {
        SceneManager.LoadScene("Level 1");
    }
}
