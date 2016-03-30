using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if(Input.GetAxis("Fire1") != 0) {
//			this.transform.Rotate(Vector3.up, 45*Time.deltaTime);
//		}
			this.transform.position = 
//			new Vector3(transform.position.x, transform.position.y + .3f, transform.position.z);
			new Vector3(transform.position.x, transform.position.y + 3 * Time.deltaTime, transform.position.z);
		}
}
