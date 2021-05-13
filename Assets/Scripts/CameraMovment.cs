using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public int position;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (position == 1)
            {

            } else if (position == 2)
            {

            } else if (position == 3)
            {

            } else if (position == 4)
            {

            }

            Debug.Log(other);
        }
    }
}
