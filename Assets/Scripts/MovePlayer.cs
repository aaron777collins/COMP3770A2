using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update

    private bool m_jump;
    private int m_canJump;
    public GameObject ground;
    public static Vector3 startPos;

    void Start()
    {
        startPos = this.gameObject.transform.position;
        // sets the jump boolean to false and how many times we have jump since the ground to 0
        m_jump = false;
        m_canJump = 0;
    }

    void FixedUpdate()
    {
        // if the z key is presed, it adds a force of 10 units in the z direction
        if (Input.GetKey("z"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 10));
        }
        if (m_jump)
        {
            // if we can jump, it adds a force of 200 to the y direciton
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 200, 0));
            // sets that we just jump
            m_jump = false;
            // increases the number of jumps tracked
            m_canJump++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if we haven't jumped more than twice, and the space bar is down
        if (m_canJump < 2 && Input.GetKeyDown("space"))
        {
            // allow the player to jump in the next fixedupdate (adds force before the physics updates)
            m_jump = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // if we hit the ground
        if (collision.gameObject == ground)
            // reset the number of jumps!
            m_canJump = 0;
    }

    void OnCollisionExit(Collision collision)
    {
     //   if (collision.gameObject == ground)
     //       m_canJump = 0;
    }
}