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
        // Get movement Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        // Get action Input
        if (Input.GetButtonDown("Action1"))
        {
            playerCharacter.Action1();
        }
        if (Input.GetButtonDown("Action2"))
        {
            playerCharacter.Action2();
        }
    }

    void FixedUpdate()
    {
        playerCharacter.Move(movement);
    }
}
