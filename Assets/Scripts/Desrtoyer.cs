using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desrtoyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
