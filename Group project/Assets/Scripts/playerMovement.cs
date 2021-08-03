using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	public int speed = 10;
	Rigidbody rb;
	public int maxJumps = 2;
	public float jumpForce = 30.0f;
	int jumping = 1;
	int x = 0;
	bool left = false;
	bool right = false;
	float timer = 0;
	bool timerunning = false; 
	// Start is called before the first frame update
	void Start()
    {
		jumping = maxJumps;
		rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.A) && left == false && timerunning == false)
		{
			x = x - 3;
			transform.position = new Vector3(x, transform.position.y, transform.position.z);
			timer = 30.0f;
			timerunning = true;
		}
		if (Input.GetKey(KeyCode.D) && right == false && timerunning == false)
		{
			x = x + 3;
			transform.position = new Vector3(x, transform.position.y, transform.position.z);
			timer = 30.0f;
			timerunning = true;
		}
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(Input.GetButtonDown("Jump") && jumping > 0)
		{
			jumping = jumping - 1;
			rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}
        if(timer > 0)
		{
			timer -= 1;
		}
        else 
		{
			timerunning = false;
		}
	}
    void OnCollisionEnter(Collision other)
	{
        if(other.gameObject.CompareTag("Ground"))
		{
			jumping = maxJumps;
			left = false;
			right = false;
		}
		if (other.gameObject.CompareTag("LeftLane"))
		{
			left = true;
			right = false;
			jumping = maxJumps;
		}
		if (other.gameObject.CompareTag("RightLane"))
		{
			jumping = maxJumps;
			left = false;
			right = true;
		}
	}
}
//Ask what the function for button pressed is instead of button held
