using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Sets the camera's position to equal the player's position plus an offset
        this.gameObject.transform.position = player.transform.position + new Vector3(0, 10, -10);
        // Sets the camera's view to look at the player
        this.gameObject.transform.LookAt(player.transform);
        // we called the updates for the camera in the Update function because it happens AFTER the physics calculations (which are using for movements). This makes sure
        // our camera is properly following the user.
    }
}
