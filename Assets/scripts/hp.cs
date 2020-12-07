using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour {

    [SerializeField]
    private float hp_amount = 10f;
    [SerializeField]
    private bool is_destroy = true;
    [SerializeField]
    private AudioClip clip;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            hp_control.change_hp(hp_amount);
            hp_control.playClip(clip);
            if (is_destroy)
                Destroy(gameObject);
        }
    }

}
