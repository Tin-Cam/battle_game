using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 2;

    private Vector2 movement;
    private Rigidbody2D rig;

    void Start() {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    
    void FixedUpdate()
    {
        rig.MovePosition(rig.position + movement * speed * Time.deltaTime);
    }
}
