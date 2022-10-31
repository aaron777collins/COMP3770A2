using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float xRotation = 30f;
    public float yRotation = 15f;
    public float zRotation = 45f;
    public GameObject player;

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Rotate(xRotation * Time.fixedDeltaTime, yRotation * Time.fixedDeltaTime, zRotation * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            this.gameObject.SetActive(false);
        }
    }
}
