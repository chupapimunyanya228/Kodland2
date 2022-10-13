using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventilator : MonoBehaviour
{
    [SerializeField] Vector3 winDir;

    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(winDir, ForceMode.Acceleration);
    }
}
