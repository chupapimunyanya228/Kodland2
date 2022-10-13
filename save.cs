using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save : MonoBehaviour
{   [SerializeField] string s;
    // Start is called before the first frame update
    void Start()
    {
        transform.position= new Vector3 (PlayerPrefs.GetFloat("x"+s,transform.position.x),PlayerPrefs.GetFloat("y"+s,transform.position.y),PlayerPrefs.GetFloat("z"+s,transform.position.z));
      //  new Vector3(x,y,z)
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("x"+s,transform.position.x);
        PlayerPrefs.SetFloat("y"+s,transform.position.y);
        PlayerPrefs.SetFloat("z"+s,transform.position.z);
        
    }
}
