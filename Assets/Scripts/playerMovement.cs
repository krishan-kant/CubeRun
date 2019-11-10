using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SideForce = 500f;
    public float Accl = 12000f;
    public float Daccl = 12000f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0,Accl * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0,0, -1 * Daccl * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-1 * SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange );
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
