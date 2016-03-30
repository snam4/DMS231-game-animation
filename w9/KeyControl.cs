using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeyControl : MonoBehaviour {
	float speed = 2f;
	Dictionary<KeyCode, Vector3> directions; 

	// Use this for initialization
	void Start () {
				directions = new Dictionary<KeyCode, Vector3>() {
				{KeyCode.W, Vector3.forward}, //move forward
				{KeyCode.S, Vector3.back}, //move backwards
				{KeyCode.A, Vector3.left}, //move left
				{KeyCode.D, Vector3.right}}; //move right
	}
	
	// Update is called once per frame
	void Update () {
		foreach(KeyCode direction in directions.Keys) {
			if(Input.GetKey(direction)) {
				this.transform.Translate(directions[direction] * speed * Time.deltaTime, Space.Self);
			}
		}
	}
}
