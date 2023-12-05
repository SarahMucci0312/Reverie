using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    //Variables
    public int enemyHP = 1; //generic enemy HP, to be change in Prefab
    private Rigidbody2D spider;

    //Get Enemy component
    private void Start()
    {
        spider = GetComponent<Rigidbody2D>();
    }

    //Check & update Enemy status
    private void Update()
    {
        if (enemyHP > 0)
        {
            spider.velocity = Vector3.down * NightmareParams.newEnemySpeed;
        }

    }

    //Damage Enemy when Player shoots
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            enemyHP--;

            //Kill Enemy when HP = 0
            if(enemyHP == 0)
            {
                NightmareParams.isDead = true;
                Destroy(gameObject);
            }
        }

    }

    //Enemy self-detstructs at domain point
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }

}
