using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    private PlayerController player;
    public int magicBoost;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    public void Use()
    {
        player.magic += magicBoost;
        Destroy(gameObject);
    }
}
