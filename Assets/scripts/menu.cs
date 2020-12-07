using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {
    public void StartMenu() { SceneManager.LoadScene("menu"); }
    public void StartLevelFirst() { SceneManager.LoadScene("start"); }
    public void StartLevelSecond() { SceneManager.LoadScene("level2"); }
    public void Quit(){ Application.Quit(); }
}
