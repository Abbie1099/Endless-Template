using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{
    public GameObject obstacle;
    public static int numberofcoins;



    void Start()
    {
        StartCoroutine(spawn());
        numberofcoins = 0;
    }
    IEnumerator spawn()
    {
        yield return new WaitForSeconds(Random.Range(1.0f,5.0f));
        GameObject ob = Instantiate(obstacle,transform.position,transform.rotation);
        Destroy(ob, 30.0f);
      

        StartCoroutine(spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
