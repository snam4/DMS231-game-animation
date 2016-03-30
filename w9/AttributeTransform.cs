using UnityEngine;
using System.Collections;

public class AttributeTransform : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				Vector3 target = new Vector3 (100, 200, 500);
//			float tSpeed = 2;
//			this.transform.Translate (0f, 0f, (tSpeed * Time.deltaTime), Space.Self);
//
//			float rSpeed = 90;
//			this.transform.Rotate(0f, (rSpeed * Time.deltaTime), 0f, Space.Self);
				MoveTowardsTarget(target);
	}

	private void MoveTowardsTarget(Vector3 targetPosition) {
				//the speed, in units per second, we want to move towards the target
		float speed = 1;

		Vector3 currentPosition = this.transform.position;
				//first, check to see if we're close enough to the target
				//this check prevents us from oscillating back and forth over the target
				//if we're farther than 1 unit away, do the movement, otherwise do nothing
		if(Vector3.Distance(currentPosition, targetPosition) > 1) { 

						//get the direction we need to go by subtracting the current position from the target position
			Vector3 directionOfTravel = targetPosition - currentPosition;
						//now normalize the direction, since we only want the direction information
			directionOfTravel.Normalize();
			Debug.Log (directionOfTravel);
						//now move at the specified speed in the direction of travel
						//scale the movement on each axis by the directionOfTravel vector components

			this.transform.Translate(
				(directionOfTravel.x * speed * Time.deltaTime),
				(directionOfTravel.y * speed * Time.deltaTime),
				(directionOfTravel.z * speed * Time.deltaTime),
				Space.World);
			}
		}
}
