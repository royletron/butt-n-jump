using UnityEngine;
using System.Collections;

public class Emitter : MonoBehaviour {

	public Rigidbody2D prefab;
	public float emitRate = 2.56f;
	public int position = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x >= (emitRate*position)) {
			Rigidbody2D instance = (Rigidbody2D) Instantiate(prefab, transform.position, transform.rotation);
			position = position + 1;
		}
	}
}
