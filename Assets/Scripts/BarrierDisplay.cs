using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BarrierDisplay : MonoBehaviour
{ 
    //For Displaying Stats in TUtorial 2
    [SerializeField] public TMP_Text playerHPtext;
    [SerializeField] public TMP_Text barrierLVL;

    public void Awake()
    {
        playerHPtext.text = "HP: " + NightmareParams.newPlayerHP;
        barrierLVL.text = "Barrier LVL: " + NightmareParams.newBarrierHP;
    }
}
