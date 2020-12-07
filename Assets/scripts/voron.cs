using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voron : MonoBehaviour {

    public int hp = 100;
    [SerializeField]
    private int yron = 10;
    [SerializeField]
    private bool isYron = false;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        print(col.tag);
        if (col.tag == "fire")
        {
            hp -= yron;
            animator.enabled = false;
            transform.position = transform.position - new Vector3(1, 0, 0);
        }

    }


    void Update ()
    {
        if (!animator.enabled)
            animator.enabled = true;
        if (hp <= 0)
            Destroy(transform.parent.gameObject);
	}
}
