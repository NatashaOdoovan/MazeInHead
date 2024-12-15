using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (SceneManager.sceneCount == 1)
            SceneManager.LoadScene("Quest_1");
    }
}
