using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIISpawn : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator EnemySpawn()
    {
        yield return new WaitForSeconds(Random.Range(1.0f, 30.0f));
        GameObject ob = Instantiate(prefab, transform.position, transform.rotation);
        Destroy(ob, 15);
        StartCoroutine(EnemySpawn());
    }

}
