using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class player : MonoBehaviour
{
    private Rigidbody2D playerBody2D;
    private static SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCol;
    private Animator animator;
    [SerializeField]
    private float maxSpeed = 25f;
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float jump = 5f;
    [SerializeField]
    private bool isSitdown = false;
    public static bool isDanger = false;
    [SerializeField]
    public GameObject HP;

    private float horizontalInput, verticalInput, fire1;

    [SerializeField]
    public GameObject Zbroa;
    private BoxCollider2D ZB_bc;
    void Start()
    {
        playerBody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        boxCol = GetComponent<BoxCollider2D>();
        ZB_bc = Zbroa.GetComponent<BoxCollider2D>();
    }
    void Update() {
         horizontalInput = Input.GetAxis("Horizontal");
         verticalInput = Input.GetAxis("Jump");
         fire1 = Input.GetAxis("Fire1");

        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("isStep", false);
            isSitdown = true;
            boxCol.offset = new Vector2(boxCol.offset.x, -0.5f);
            boxCol.size = new Vector2(boxCol.size.x, 4f);
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            changeColor(true);
            isSitdown = false;
            animator.SetBool("isSitdownStep", false);
            animator.SetBool("isSitdown", false);
            boxCol.offset = new Vector2(boxCol.offset.x, 0);
            boxCol.size = new Vector2(boxCol.size.x, 5f);
        }

        animator.SetBool("isFire", Convert.ToBoolean(fire1));
        if (Convert.ToBoolean(fire1))
        {
            ZB_bc.enabled = true;
        }
        else
        {
            ZB_bc.enabled = false;
        }
        if (isSitdown && !Convert.ToBoolean(horizontalInput))
            animator.SetBool("isSitdown", true);
        else if (isSitdown && Convert.ToBoolean(horizontalInput))
            animator.SetBool("isSitdownStep", Convert.ToBoolean(horizontalInput));
        else
            animator.SetBool("isStep", Convert.ToBoolean(horizontalInput));
    }
    [SerializeField]
    public static float timeToWait = 10f;
    public static float done = 0.0f;

    public static void changeColor(bool val)
    {
        spriteRenderer.color = new Color(0.7f, 1f, 0.7f);
       
        spriteRenderer.color = new Color(0.3f, 0.5f, 0.5f);
    }

    void FixedUpdate()
    {
        if (0 < horizontalInput)
            spriteRenderer.flipX = false;

        if (horizontalInput < 0)
            spriteRenderer.flipX = true;
        
        Vector3 eulerRotation = transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 0);
        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, verticalInput * speed * Time.deltaTime, 0);
    }
}
