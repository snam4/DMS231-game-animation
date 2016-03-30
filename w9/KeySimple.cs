using UnityEngine;
using System.Collections;
//http://answers.unity3d.com/questions/982576/change-material-color-of-an-object-c.html

public class KeySimple : MonoBehaviour {
		public Renderer rend;
		private Color color = new Color(0.0F, 0.0F, 0.0F, 0.0F);
		public Color colorEnd = Color.green;
		public float duration = 1.0F;

	// Use this for initialization
	void Start () {
				rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
			rend.material.color = color;
			Debug.Log (color);
			if(Input.GetAxis("Fire1") != 0) {
				this.transform.Rotate(Vector3.up, 45*Time.deltaTime);
			}
			if(Input.GetKeyDown(KeyCode.Space)) {
				this.transform.Translate(5f,0f,0f, Space.World);
			}
			if (Input.GetKey (KeyCode.Space)) {
				this.transform.Rotate (Vector3.up, 45 * Time.deltaTime);
//				float lerp = Mathf.PingPong(Time.time, duration) / duration;
//				rend.material.color = Color.Lerp(color, colorEnd, lerp);
				if (color.r < 1) {
					color.r += 0.01f;
				}
			}
			if(Input.GetKeyUp(KeyCode.Space)) {
				this.transform.Translate(-5f,0f,0f, Space.World);
				color.r = 0f;
				color.g = 0f;
				color.b = 0f;
			}
	}
}
