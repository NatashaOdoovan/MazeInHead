using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (SceneManager.sceneCount == 0)
            SceneManager.LoadScene("Maze_2");

        else if (SceneManager.sceneCount == 1)
            SceneManager.LoadScene("Maze_2");

        else if (SceneManager.sceneCount == 2)
            SceneManager.LoadScene("NoWay");


    }
}
