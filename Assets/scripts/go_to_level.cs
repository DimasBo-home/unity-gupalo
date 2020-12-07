using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_to_level : MonoBehaviour
{
    [SerializeField]
    private int SchenaIndex = 0;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
            SceneManager.LoadScene(SchenaIndex);
    }
}