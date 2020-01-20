using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody rd;
    public float forwardForce;
    public float sidewiseForce;

    // Update is called once per frame
    void FixedUpdate()
    {
        rd.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rd.AddForce(sidewiseForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rd.AddForce(-sidewiseForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(rd.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
