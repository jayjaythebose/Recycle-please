using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
   public void QuitGameButton() 
   {
        Application.Quit();
        Debug.Log("Game Stoped");
   }
}
