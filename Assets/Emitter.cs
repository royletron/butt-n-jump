using UnityEngine;
using System.Collections;

public class Emitter : MonoBehaviour {

	public Rigidbody2D[] prefabs;
	public bool continuous = true;
	public float emitRate = 2.56f;
	public int position = 2;
	public bool random = false;
	public float minDelay = 1.0f;
	public float maxDelay = 2.0f;

	private float timeCounter = 0.0f;
	private float timeTarget;


	private float OffsetX;

	// Use this for initialization
	void Start () {
		OffsetX = transform.position.x - Camera.main.transform.position.x;
		if (random) {
			SetTime();
		}
	}

	void SetTime(){
		timeTarget = Random.Range(minDelay*100, maxDelay*100)/100;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2(Camera.main.transform.position.x + OffsetX, transform.position.y);
		//print (transform.position);
		if (continuous) {
			if (transform.position.x >= (emitRate * position)) {
				Rigidbody2D instance = (Rigidbody2D)Instantiate (prefabs[Random.Range(0,prefabs.Length)], new Vector2 (emitRate * position, transform.position.y), transform.rotation);
				//instance.position = new Vector2(emitRate*position, instance.position.y);
				position = position + 1;
			}
		} else {
			if (random) {
				timeCounter = timeCounter + Time.deltaTime;
				if(timeCounter > timeTarget) {
					timeCounter = 0.0f;
					SetTime();
					Rigidbody2D instance = (Rigidbody2D)Instantiate (prefabs[Random.Range(0,prefabs.Length)], transform.position, transform.rotation);
				}
			}
		}
	}
}
