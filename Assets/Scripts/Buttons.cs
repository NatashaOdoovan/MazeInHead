using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public void GoToMaze_1()
    {
        SceneManager.LoadScene("Maze_1");
       

    }

    public void GoToMaze_2()
    {
        SceneManager.LoadScene("Maze_2");

    }

   
    public void ExitGame()
    {
        Application.Quit();
    }
   
}
