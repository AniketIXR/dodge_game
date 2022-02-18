using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	//This is a reference to the Rigidbody component called  'rb'
	public Rigidbody rb;
	public float forwardForce=2000f;
	public float sidewayForce=500f;
	//use made the default Update method() to FixedUpadate to make unity to understand better of efficiency of Physics class
	void FixedUpdate () 
	{
		rb.AddForce (00, 00, forwardForce*Time.deltaTime);	

		if (Input.GetKey ("d")) 
		{
			rb.AddForce (sidewayForce * Time.deltaTime,00,00,ForceMode.VelocityChange);
		}



		if (Input.GetKey ("a")) 
		{
			rb.AddForce (-sidewayForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
		}
        if(rb.position.y<11.1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

	}
}
