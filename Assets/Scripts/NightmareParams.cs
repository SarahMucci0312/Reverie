using TMPro;
using UnityEngine;

public class NightmareParams : MonoBehaviour
{

    public static int numDialogues = 0;
    public float winningChance = 50;
    [SerializeField] public TMP_Text dialoguesText;
    [SerializeField] public TMP_Text winningChanceText;

    //Prevents player from trying to talk to two NPCs at the same time
    public static bool isTalking = false;

    //Values to pass to NIGHTMARE scene
    public static int newPlayerHP = 20;
    public static int newBarrierHP = 0;
    public static int newNumHPs = 1;
    public static float newEnemySpeed = 1;
    public static bool isDead = false;

    private void Awake()
    {
        dialoguesText.text = "Progress: " + numDialogues + "/10";
        winningChanceText.text = "Winning Chance: " + winningChance + "%";
    }

    //Increase dialogues for every choice made
    public void IncreaseDialogues()
    {
        numDialogues++;
        dialoguesText.text = "Progress: " + numDialogues + "/10";
    }

    //Modify winning chance depending on player choices
    public void WinningChance(float num)
    {
        winningChance += num;
        if (winningChance < 0)
        {
            winningChance = 0;
        }
        if(winningChance > 100)
        {
            winningChance = 100;
        }
        winningChanceText.text = "Winning Chance: " + winningChance + "%";
    }

    //Decrease player HP penalty
    public void DecreasePlayerHP(int decrease)
    {
        newPlayerHP -= decrease;
    }

    //Increase player Health Packs reward
    public void IncreaseHealthPacks(int increase)
    {
        newNumHPs += increase;

    }

    //Increase barrier level reward
    public void ChangeBarrier(int num)
    {
        newBarrierHP += num;
    }

    //Modify enemy speed depending on player choices
    public void IncreaseEnemySpeed(float num)
    {
        newEnemySpeed += num;
    }

    //Change enemy speed multiplier depending on player choices
    public void ChangeEnemySpeed(float num)
    {
        newEnemySpeed *= num;
    }

    //Function to prevent player from trying to talk to two NPCs at the same time
    public void Talking()
    {
        if(isTalking == false)
        {
            isTalking = true;
        }
        else
        {
            isTalking = false;
        }
    }

}
