using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody rb;

    public float forwardForce = 300f;
    public float sidewaysForce = 500f;

    // For physics use FixedUpdate instead of Update
    void FixedUpdate() {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0);
        }
        if(Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0);
        }
    }
}
