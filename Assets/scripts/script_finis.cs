using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_finis : MonoBehaviour {
    private Animator animator;

    void Start () {   animator = GetComponent<Animator>();}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
            animator.enabled = true;

    }
}