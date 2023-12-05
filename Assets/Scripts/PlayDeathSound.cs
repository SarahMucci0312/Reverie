using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDeathSound : MonoBehaviour
{
    public AudioSource death;

    // Update is called once per frame
    void Update()
    {
        if (NightmareParams.isDead == true)
        {
            death.Play();
            NightmareParams.isDead = false;
        }
    }
}
