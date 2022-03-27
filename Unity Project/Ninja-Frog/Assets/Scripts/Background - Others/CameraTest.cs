using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour
{
    private Vector3 StartingRoom = new Vector3(0,0,-10);
    private Vector3 TreasureRoomRight = new Vector3(30,0,-10);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = StartingRoom;
    }

    // Update is called once per frame
    void Update()
    {
        // Switches Cameras Through Rooms.
        if (Input.GetKeyDown("1"))
        {
            transform.position = StartingRoom;

        }

        if (Input.GetKeyDown("2"))
        {
            transform.position = TreasureRoomRight;
            
        }
      
    }
}
