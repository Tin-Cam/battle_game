using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 2;
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x, y, 0);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
