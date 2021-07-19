using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movespeed = 5f;
    [SerializeField] private float dashspeed = 20f;
    [SerializeField] private float jumpspeed = 10f;

    private float jump_start_time = 0.0f;
    private float max_jump_dur = 0.4f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float hor_dir = Input.GetAxisRaw("Horizontal");
        Debug.Log(Input.GetAxisRaw("Horizontal"));
        rb.velocity = new Vector2(hor_dir * movespeed, rb.velocity.y);

        if(Input.GetButton("Jump")) {
            Debug.Log("Player Jumped!");
        }
    }
}
