using UnityEngine;
using System.Xml;

public class LevelControl : MonoBehaviour {

    [SerializeField]
    private XmlDocument docSetting;
   
    void Start()
    {
        Debug.Log(docSetting);
    }
}
