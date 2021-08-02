using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	public int speed = 10;
	Rigidbody rb;
	public int maxJumps = 2;
	public float jumpForce = 8.0f;
	int jumping = 2;
	bool changingLanes = false;
	// Start is called before the first frame update
	void Start()
    {
		jumping = maxJumps;
		rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
		{
			//transform.position.x = transform.position.x - 3;
		}
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(Input.GetButtonDown("Jump") && jumping > 0 && changingLanes == false)
		{
			jumping = jumping - 1;
			rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}
	}
    void OnCollisionEnter(Collision other)
	{
        if(other.gameObject.CompareTag("Ground"))
		{
			jumping = maxJumps;
		}
	}
}
//Ask what the function for button pressed is instead of button held
