using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarTrigger2 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (SceneManager.sceneCount == 2)
            SceneManager.LoadScene("Quest_3");
    }
}
