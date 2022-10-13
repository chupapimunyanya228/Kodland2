using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firegun : Shotgun
{
    // Start is called before the first frame update
    void Start()
    {
        auto = true;
        cooldown = 0.1f;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
