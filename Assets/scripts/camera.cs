using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float x_kofithient = 2f;
    [SerializeField]
    private float y_kofithient = 1f;
    [SerializeField]
    private float position_x, position_y;
    
    void Start()
    {
        position_x = transform.position.x;
        position_y = transform.position.y;
    }

    void Update()
    {
        if (transform.position.x - player.transform.position.x > x_kofithient)
            position_x = player.transform.position.x + x_kofithient;
        else if (player.transform.position.x - transform.position.x > x_kofithient)
            position_x = player.transform.position.x - x_kofithient;

        if (transform.position.y - player.transform.position.y > y_kofithient)
            position_y = player.transform.position.y + y_kofithient;
        else if (player.transform.position.y - transform.position.y > y_kofithient)
            position_y = player.transform.position.y - y_kofithient;



        if (transform.position.x - player.transform.position.x > x_kofithient ||
            transform.position.y - player.transform.position.y > y_kofithient ||

            player.transform.position.x - transform.position.x > x_kofithient ||
            player.transform.position.y - transform.position.y > y_kofithient
            )
            transform.position = new Vector3(position_x, position_y, transform.position.z);

    }

}
