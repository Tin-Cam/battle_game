using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_PlayerCharacter : MonoBehaviour, ICharacter, IPlayerControllable
{
    public int maxHealth { get; }
    public int currentHealth { get; }

    [SerializeField]
    private int moveSpeed;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector2 movement){
        rig.MovePosition(rig.position + movement * moveSpeed * Time.deltaTime);
    }

    public void Action1(){

    }

    public void Action2(){

    }

    public void TakeDamage(float value){

    }
}
