using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))   
       {
           GetComponent<Animator>().SetBool("Dance", true);   
       }
       if (Input.GetKeyUp(KeyCode.F))
       {
            GetComponent<Animator>().SetBool("Dance", false);
       }   
        
    }
}
