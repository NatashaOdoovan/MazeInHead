using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarTrigger1 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (SceneManager.sceneCount == 2)
            SceneManager.LoadScene("Quest_2");
    }
}
