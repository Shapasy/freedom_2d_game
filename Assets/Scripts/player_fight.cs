using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class player_fight : MonoBehaviour
{
    public Animator animator;
    public Transform attack_point;
    public float attack_range;
    public LayerMask enemy_layer;
    public AudioSource audio;

    void Start()
    {
        this.attack_range = 0.7f;
        this.audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.audio.Play();
            animator.SetTrigger("attack");
            this.attack();
        }
    }

    private void attack()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(attack_point.position, attack_range, enemy_layer);
        foreach(Collider2D enemy in enemies)
        {
           enemy.GetComponent<WoodDoll_Mgr>().curr_hit_counter--;
        }
    }

    /*void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attack_point.position, attack_range);
    }*/
}
