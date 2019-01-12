using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public Vector3 jump;
    public float jumpForce = 2.0f;

    private bool isGrounded;
    private bool blocksDestroyed = false;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 v = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(v * speed);

        GameObject goal1 = GameObject.Find("Goal1");
        GameObject goal2 = GameObject.Find("Goal2");
        if (!goal1 && !goal2 && !blocksDestroyed)
        {
            blocksDestroyed = true;

            // Spawn bridge here
        }

    }

}
