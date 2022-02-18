
using UnityEngine;

public class AddColision : MonoBehaviour {

	// Use this for initialization
	public PlayerMovement movement; //A reference to the PlayerMovement Script
    

    //This function is called when we hit any obstacle
    //We get information about collision amd called it as collosioninfo
	void OnCollisionEnter(Collision collisioninfo)
	{
		if (collisioninfo.collider.tag == "Obstacle") 
		{
			
			movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
		}
	}
}
