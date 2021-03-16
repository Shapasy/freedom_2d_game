using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class end : MonoBehaviour
{

    public Animator animator;
    public static int movespeed = 12;
    public Vector3 userDirection = Vector3.right;

    public void Update()
    {
        if(transform.position.x >= 316)
        {
            transform.position = new Vector3(200,transform.position.y,transform.position.z);
        }
        transform.Translate(userDirection * movespeed * Time.deltaTime);
        animator.SetFloat("horz", 2f);

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
