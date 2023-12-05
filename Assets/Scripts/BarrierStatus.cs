using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BarrierStatus : MonoBehaviour
{
    //Variables
    private int enemyHP;
    private int temp = 0;
    [SerializeField] public TMP_Text playerHPtext;
    [SerializeField] public TMP_Text barrierLVL;

    //Timer
    public float timeRemaining = 55;
    public bool timerIsRunning = false;

    public void Awake()
    {
        playerHPtext.text = "HP: " + NightmareParams.newPlayerHP;
        barrierLVL.text = "Barrier LVL: " + NightmareParams.newBarrierHP;
    }

    private void Start()
    {
        timerIsRunning = true;
    }

    void Update()
    {
        //Update timer
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
        //If player survives after timer runs out, load victory screen
        else
        {
            if(NightmareParams.newPlayerHP > 0)
            {
                SceneManager.LoadScene(4);
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        enemyHP = other.gameObject.GetComponent<EnemyScript>().enemyHP;

        //Check for damage done to barrier
        if(NightmareParams.newBarrierHP > 0)
        {
            //Checks if barrier is destroyed
            if(enemyHP > NightmareParams.newBarrierHP)
            {
                temp = enemyHP - NightmareParams.newBarrierHP;
                NightmareParams.newBarrierHP = 0;
                barrierLVL.text = "Barrier LVL: " + NightmareParams.newBarrierHP;
                enemyHP = temp;
                NightmareParams.newPlayerHP -= enemyHP;
                playerHPtext.text = "HP: " + NightmareParams.newPlayerHP;
            }
            //Only updates barrier damage if barrier not destroyed
            else
            {
                NightmareParams.newBarrierHP -= enemyHP;
                barrierLVL.text = "Barrier LVL: " + NightmareParams.newBarrierHP;
            }
        }
        //Damage done to player only
        else
        {
            NightmareParams.newPlayerHP -= enemyHP;
            playerHPtext.text = "HP: " + NightmareParams.newPlayerHP;
        }
        //If player dies, game over
        if (NightmareParams.newPlayerHP < 1)
        {
            SceneManager.LoadScene(3);
        }

    }

}
