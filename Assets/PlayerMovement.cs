using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody rb;



    // Update is called once per frame
    void FixedUpdate() {
        rb.AddForce(0,0,2000 * Time.deltaTime);
    }
}
