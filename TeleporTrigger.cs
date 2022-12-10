using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporTrigger : MonoBehaviour
{

    public Transform teleportPoint;
    public GameObject Player;
    
    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = teleportPoint.transform.position;
    }
    
}
