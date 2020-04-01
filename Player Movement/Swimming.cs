using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swimming : MonoBehaviour
{
    public Rigidbody Player;
    public UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController Controller;
    private bool Swiming = false;
    public KeyCode SwimmingUp = KeyCode.Space;
    public KeyCode SwimmingDown = KeyCode.LeftControl;
    public KeyCode forward = KeyCode.W;
    public KeyCode backward = KeyCode.S;
    public int SwimSpeed=1;

    void Update()
    {
        if (transform.position.y < 30) { Swiming = true; Player.mass = .5f; Player.useGravity = false; }
        else if (transform.position.y > 35) { Swiming = false; Player.mass = 20; Player.useGravity = true; }
        if (Swiming)
        {
            if (Input.GetKey(SwimmingUp)) 
            {
                transform.Translate(0, 5 * Time.deltaTime*SwimSpeed, 0);
            }
            else if (Input.GetKey(SwimmingDown))
            {
                transform.Translate(0, -5*Time.deltaTime*SwimSpeed, 0);
            }
            if (Input.GetKey(forward))
            {
                transform.Translate(10 * Time.deltaTime * SwimSpeed, 0, 0);
            }
            if (Input.GetKey(backward))
            {
                transform.Translate(-5 * Time.deltaTime * SwimSpeed, 0, 0);
            }
        }
    }
}
