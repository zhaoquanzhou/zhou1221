using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Die()
    {
        anim.SetBool("Dead", true);
        Destroy(gameObject, 1.5f);
    }
}