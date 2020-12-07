using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hp_control : MonoBehaviour {
    
    public static Slider instance;
    private static AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        instance = GetComponent<Slider>();
    }
    public static void playClip(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    void Update()
    {
        if (instance.value <= 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public static void change_hp(float val)
    {
        if (instance.value + val > 100)
            instance.value = 100;
        else if (instance.value + val < 0)
            instance.value = 0;
        else
            instance.value += val;
    }
}
