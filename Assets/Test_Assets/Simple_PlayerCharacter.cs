using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_PlayerCharacter : MonoBehaviour, ICharacter, IPlayerControllable
{
    public int maxHealth { get; }
    public int currentHealth { get; }

    [SerializeField]
    private int moveSpeed;

    [SerializeField]
    private GameObject sword;

    [SerializeField]
    private float attackSpeed;
    private float attackSpeedTimer;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSword();
    }

    public void Move(Vector2 movement){
        rig.MovePosition(rig.position + movement * moveSpeed * Time.deltaTime);
    }

    // Sword attack
    public void Action1(){
        if(attackSpeedTimer > 0) {
            return;
        }

        // 1 Play Animation
        // 2 Spawn Attack point / sword
        attackSpeedTimer = attackSpeed;
        // 3 Do damage if needed
    }

    private void UpdateSword() {
        if (attackSpeedTimer <= 0) {
            sword.SetActive(false);
            return;
        }
        attackSpeedTimer -= Time.deltaTime;
        sword.SetActive(true);
    }

    public void Action2(){

    }

    public void TakeDamage(float value){

    }
}
