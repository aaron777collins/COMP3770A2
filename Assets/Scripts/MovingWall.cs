using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{

    public float minX = -10;
    public float maxX = 10;
    public float speed = 5;
    public bool movingPositiveInX = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called atleast every 20ms
    void FixedUpdate()
    {
        if (movingPositiveInX)
        {
            if (this.gameObject.transform.position.x >= maxX)
            {
                movingPositiveInX = false;
                this.gameObject.transform.Translate(new Vector3(-speed * Time.fixedDeltaTime, 0, 0));
            } else
            {
                this.gameObject.transform.Translate(new Vector3(speed * Time.fixedDeltaTime, 0, 0));
            }
        } else
        {
            if (this.gameObject.transform.position.x <= minX)
            {
                movingPositiveInX = true;
                this.gameObject.transform.Translate(new Vector3(speed * Time.fixedDeltaTime, 0, 0));
            }
            else
            {
                this.gameObject.transform.Translate(new Vector3(-speed * Time.fixedDeltaTime, 0, 0));
            }
        }
    }
}
