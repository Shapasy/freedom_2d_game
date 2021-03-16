using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WoodDoll_Mgr : MonoBehaviour {

    private float prev_hit_counter;
    public float curr_hit_counter;
    public float num_hits;
    public Animator animator;
    public AudioSource audio;
    public Transform health;

    void Start()
    {
        this.prev_hit_counter = this.num_hits;
        this.curr_hit_counter = this.prev_hit_counter;
        this.audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (this.prev_hit_counter != this.curr_hit_counter)
        {
            this.audio.Play();
            animator.SetTrigger("hit");
            this.health_update();
            this.prev_hit_counter = this.curr_hit_counter;
        }
        if(this.prev_hit_counter <= 0)
        {
            //Debug.Log("Die");
            this.zero_healt_update();
            Destroy(GetComponent<PolygonCollider2D>());
            Destroy(GetComponent<BoxCollider2D>());
        }
        if (transform.position.y < -9f)
        {
            Destroy(GetComponent<Rigidbody2D>());
        }
    }


    private void health_update()
    {
         health.localScale = new Vector3(
                 (1f/this.num_hits) * (this.curr_hit_counter),
                 health.localScale.y, health.localScale.z);
    }

    private void zero_healt_update()
    {
        health.localScale = new Vector3(0f, health.localScale.y, health.localScale.z);
    }



}
