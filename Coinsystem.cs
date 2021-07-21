using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coinsystem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            EnemySpawn.numberofcoins += 1;
            Debug.Log("coins" +EnemySpawn.numberofcoins);
            Destroy(gameObject);
        }
    }
}
