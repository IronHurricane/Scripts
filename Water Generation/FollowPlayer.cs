using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject water;
    private float PX;
    private float PZ;
    private float WX;
    private float WZ;

    void Update()
    {
        PX = player.transform.position.x; PZ = player.transform.position.z;
        WX = water.transform.position.x; WZ = water.transform.position.z;
        if (WX < PX)
        {
            while (water.transform.position.x < PX)
            {
                water.transform.Translate(.1f*Time.deltaTime, 0, 0);
            }
        }
        else if (WX > PX)
        {
            while (water.transform.position.x > PX)
            {
                water.transform.Translate(-.1f * Time.deltaTime, 0, 0);
            }
        }
        if (WZ < PZ)
        {
            while (water.transform.position.z < PZ)
            {
                water.transform.Translate(0, 0, .1f * Time.deltaTime);
            }
        }
        else if (WZ > PZ)
        {
            while (water.transform.position.z > PZ)
            {
                water.transform.Translate(0, 0, -.1f * Time.deltaTime);
            }
        }
    }
}
