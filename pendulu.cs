using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulu : MonoBehaviour
{
    [SerializeField] float limit = 30f;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
       float angle = limit * Mathf.Sin(Time.time);
       transform.localRotation = Quaternion.Euler(0, 0, angle);
    }
}
