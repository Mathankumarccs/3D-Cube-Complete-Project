
using UnityEngine;

public class Playermovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwad;
    public float sideway;
    


    void Update()
    {
        rb.AddForce(0, 0, forwad * Time.deltaTime);


        if (Input.GetKey("d"))
        {
            rb.AddForce(sideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x > (Screen.width / 2))
            {

                rb.AddForce(sideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (touch.position.x < (Screen.width / 2))
            {
                rb.AddForce(-sideway * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

    }

    void AccelerometerMove()
    {

        float x = Input.acceleration.x;
        Debug.Log("X = " + x);


        if (x < -0.1f)
        {
            MoveLeft();
        }
        else if (x > 0.1f)
        {
            MoveRight();
        }
        else
        {
            SetVelocityZero();
        }

    }

    public void MoveLeft()
    {
        rb.velocity = new Vector2(-sideway, 0);
    }

    public void MoveRight()
    {

        rb.velocity = new Vector2(sideway, 0);
    }

    public void SetVelocityZero()
    {
        rb.velocity = Vector2.zero;
    }


}
