using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeyControl : MonoBehaviour {
	Dictionary<KeyCode,Vector3> directions;
	public int score;

	// Use this for initialization
	void Start () {
		directions = new Dictionary<KeyCode,Vector3> () {
			{KeyCode.W, Vector3.forward},
			{KeyCode.UpArrow, Vector3.forward},
			{KeyCode.S, Vector3.back},
			{KeyCode.DownArrow, Vector3.back},
			{KeyCode.A, Vector3.left},
			{KeyCode.LeftArrow, Vector3.left},
			{KeyCode.D, Vector3.right},
			{KeyCode.RightArrow, Vector3.right},
			{KeyCode.Space, Vector3.up},
		};
	}
	
	// Update is called once per frame
	void Update () {
		foreach(KeyCode direction in directions.Keys){
			if(Input.GetKey(direction)){
				transform.Translate(directions[direction] * 3f * Time.deltaTime, Space.Self);
			}
			
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Coin") {
			score = score + 1; // score ++;
			Destroy (other.gameObject);
		}
			}
}