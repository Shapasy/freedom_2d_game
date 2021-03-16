using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class player : MonoBehaviour
{
    private float speed;
    private float horz;
    public Animator animator;
    public bool is_level_1;

    void Start()
    {
        this.speed = 0.035f; //145 -> build , 035 -> run
    }

    void Update()
    {
        horz = Input.GetAxisRaw("Horizontal") * speed;

        transform.Translate(horz, 0, 0);

        animator.SetFloat("horz", Mathf.Abs(horz));

        if(transform.position.x >= 130.3)
        {
            if (is_level_1) SceneManager.LoadScene(2);
            else SceneManager.LoadScene(4);
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }

}