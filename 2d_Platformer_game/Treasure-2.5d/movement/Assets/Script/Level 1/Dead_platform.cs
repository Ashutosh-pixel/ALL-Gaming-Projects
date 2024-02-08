using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead_platform : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
   {
      switch (other.gameObject.tag)
      {
         case "player":
         {
            Invoke("Dead",1f);
            break;
         }
      }
   }

   void Dead()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
}
