using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bonus_control : MonoBehaviour {

    public static Text instance;
    public static int bonus;
    void Start() { instance = GetComponent<Text>(); }

    public static void plus(int val)
    {
        instance.text = "money " + bonus;
        bonus += val;
    }
}
