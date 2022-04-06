using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerLocation = 20;
        int spawnLocation = 20;
        if(playerLocation == spawnLocation)
        {
            this.Spawn();
        }

    }

    private void Spawn()
    {
        Debug.Log("Spawn");
    }
}
