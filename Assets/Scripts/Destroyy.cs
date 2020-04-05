using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyy : MonoBehaviour
{
  private Game game;

   public void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kryg"))
        {
           game.ReloadCurrentLevel();
        }
        
    }
}
