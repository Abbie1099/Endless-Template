using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform plane;
    public float initialSize = 2.4f;
    public Manager mn;
    public float score = 1;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        score += Time.deltaTime;
        txt.text =score.ToString("0");
    }

    public void movement()
    {
        
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-20.0f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(20.0f, 0.0f, 0.0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
            {
            mn.Restart();
            }
        else if(collision.gameObject.CompareTag("Enemy"))
        {
            mn.Restart();
        }
    }
}
