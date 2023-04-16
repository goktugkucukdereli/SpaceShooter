using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipCtrl : MonoBehaviour
{
    public float spaceShipSpeed;
    public float minXval, maxXval;
    public float minYval, maxYval;

    void Update()
    {
        move();
        line();
        slope();
    }

    private void move()
    {
        transform.Translate(-Input.GetAxis("Horizontal") * spaceShipSpeed, Input.GetAxis("Vertical") * spaceShipSpeed, 0f, Space.World);
    }

    private void line()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, minXval, maxXval);
        pos.y = Mathf.Clamp(pos.y, minYval, maxYval);
        transform.position = pos;
    }

    private void slope() 
    {
        transform.eulerAngles = new Vector3(0f, Input.GetAxis("Horizontal") * -30, -180f);
    }
}
