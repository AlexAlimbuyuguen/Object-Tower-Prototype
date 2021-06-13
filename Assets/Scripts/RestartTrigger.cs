using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("TestEnvironment");
    }
}
