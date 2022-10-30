using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update

    private bool m_jump;
    private int m_canJump;
    public GameObject ground;

    void Start()
    {
        m_jump = false;
        m_canJump = 0;
    }

    void FixedUpdate()
    {
        if (Input.GetKey("z"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 10));
        }
        if (m_jump)
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 200, 0));
            m_jump = false;
            m_canJump++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (m_canJump < 2 && Input.GetKeyDown("space"))
        {
            m_jump = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == ground)
            m_canJump = 0;
    }

    void OnCollisionExit(Collision collision)
    {
     //   if (collision.gameObject == ground)
     //       m_canJump = 0;
    }
}