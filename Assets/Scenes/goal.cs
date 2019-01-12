using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Block1" && gameObject.name == "Goal1")
        {
            Object.Destroy(gameObject);
            Object.Destroy(collision.gameObject);
        } else if (collision.gameObject.name == "Block2" && gameObject.name == "Goal2")
        {
            Object.Destroy(gameObject);
            Object.Destroy(collision.gameObject);
        } else if (collision.gameObject.name == "Block3" && gameObject.name == "Goal3")
        {
            Object.Destroy(gameObject);
            Object.Destroy(collision.gameObject);
        }
    }
}
