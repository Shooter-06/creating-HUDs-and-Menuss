using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 2;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal")*speed,rb.velocity.y,0);
        rb.velocity = move;
    }
    void OnCollisionEnter(Collision other) {

        if (other.gameObject.CompareTag("Fruit")) {
            GameManager.Instance.UpdateScore();

            Destroy (other.gameObject);
        }
        
        
    }
}
