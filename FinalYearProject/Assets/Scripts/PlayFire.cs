using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFire : MonoBehaviour
{
    public ParticleSystem fire;

    private void Start()
    {
        fire.Play();
    }
}
