using UnityEngine;
using System.Collections;

public class Emitter : MonoBehaviour {

	public Rigidbody2D prefab;
	public float emitRate = 2.56f;
	public int position = 2;
	public bool continuous = true;

	private float OffsetX;

	// Use this for initialization
	void Start () {
		OffsetX = transform.position.x - Camera.main.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2(Camera.main.transform.position.x + OffsetX, transform.position.y);
		//print (transform.position);
		if (continuous) {
			if (transform.position.x >= (emitRate * position)) {
				Rigidbody2D instance = (Rigidbody2D)Instantiate (prefab, new Vector2 (emitRate * position, transform.position.y), transform.rotation);
				//instance.position = new Vector2(emitRate*position, instance.position.y);
				position = position + 1;
			}
		} else {

		}
	}
}
