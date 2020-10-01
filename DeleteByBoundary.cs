using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteByBoundary : MonoBehaviour
{
    public int scoreValue;
    public GameController gameController;

    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        gameController.AddScore(scoreValue);
    }
}
