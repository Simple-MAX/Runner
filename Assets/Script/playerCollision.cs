using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public PlayerMovments movments;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacl")
        {
            Debug.Log("your dead");
            movments.enabled = false;
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}
