using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forawardForce = 1000f;
    public float sidewaysForce = 100f;
    public PlayerMovement movement;
    public Transform player;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forawardForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (player.position.y < 0)
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}