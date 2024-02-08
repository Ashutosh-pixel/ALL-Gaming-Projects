using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
   public void restart_()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
}
