using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class to_level_2 : MonoBehaviour
{

    public Animator animator;
    public static int movespeed = 12;
    public Vector3 userDirection = Vector3.right;

    void Update()
    {
       if (transform.position.x >= 316)
        {
          transform.position = new Vector3(200, transform.position.y, transform.position.z);
        }
        transform.Translate(userDirection * movespeed * Time.deltaTime);
        animator.SetFloat("horz", 2f);

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(3);
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
