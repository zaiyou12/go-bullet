using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteByBoundary : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
