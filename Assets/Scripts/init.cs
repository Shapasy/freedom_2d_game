using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class init : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
