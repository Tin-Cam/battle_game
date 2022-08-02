using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private IPlayerControllable playerCharacter;
    private Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        playerCharacter = GetComponent<IPlayerControllable>();
    }
    

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        playerCharacter.Move(movement);
    }
}
