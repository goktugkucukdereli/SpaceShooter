using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    //    public float spaceShipSpeed;
    //    public GameObject spaceShip;

    //    private Rigidbody spaceShipBody;
    //    private float ScreenWidth;
    //    void Start()
    //    {
    //        ScreenWidth = Screen.width;
    //        spaceShipBody = spaceShip.GetComponent<Rigidbody>();
    //    }


    //    void Update()
    //    {
    //        int i = 0;

    //        while (i < Input.touchCount)
    //        {
    //            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
    //            {
    //                RunCharacter(1.0f);
    //            }
    //            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
    //            {
    //                RunCharacter(-1.0f);
    //            }
    //            ++i;
    //        }
    //    }

    //    private void FixedUpdate()
    //    {
    //#if UNITY_EDITOR
    //        RunCharacter(Input.GetAxis("Horizontal"));
    //#endif
    //    }

    //    private void RunCharacter(float horizontalInput)
    //    {
    //        spaceShipBody.AddForce(new Vector3(horizontalInput * spaceShipSpeed * Time.deltaTime, 0));
    //    }



    //private void Update()
    //{
    //    if(Input.touchCount > 0)
    //    {
    //        Touch touch = Input.GetTouch(0);

    //        if(touch.phase == TouchPhase.Began)
    //        {
    //            if (touch.position.x < Screen.width / 2 && transform.position.x > -1.75f)
    //                transform.position = new Vector3(transform.position.x - 1.75f, transform.position.y);

    //            if(touch.position.x < Screen.width / 2 && transform.position.x < -1.75f)
    //                transform.position = new Vector3(transform.position.x + 1.75f, transform.position.y);
    //        }
    //    }
    //}

    private Touch touch;
    private float speedModifier;

    private void Start()
    {
        speedModifier = 0.02f;
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x - touch.deltaPosition.x * speedModifier, transform.position.y + touch.deltaPosition.y * speedModifier, 8f);
            }
        }
    }
}
