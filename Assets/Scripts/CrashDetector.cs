using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            Invoke("ReloadScene", 0.5f);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
