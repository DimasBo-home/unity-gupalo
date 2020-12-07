using System;
using UnityEngine;

public class coint : MonoBehaviour {

    [SerializeField]
    private int bonus = 10;
    [SerializeField]
    private AudioClip clip;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            bonus_control.plus(bonus);
            player.changeColor(Convert.ToBoolean(bonus));
            hp_control.playClip(clip);
        }
        Destroy(gameObject);
    }

}
