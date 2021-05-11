using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<RoomSpawner>())
        {
            Destroy(collision.gameObject);
            Destroy(gameObject, 2f);
        }
    }
}
