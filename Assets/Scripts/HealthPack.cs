using UnityEngine;
using TMPro;
using System.Threading;

public class HealthPack : MonoBehaviour
{
    [SerializeField] public TMP_Text healthPack;
    [SerializeField] public BarrierStatus barrier;
    
    public void Awake()
    {
        healthPack.text = "x" + NightmareParams.newNumHPs;
    }

    //Apply health pack
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && NightmareParams.newNumHPs > 0)
        {
            NightmareParams.newNumHPs--;
            healthPack.text = "x" + NightmareParams.newNumHPs;
            barrier.playerHPtext.text = "HP: " + NightmareParams.newPlayerHP + 5;
        }

    }

}
