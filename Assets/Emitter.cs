using UnityEngine;
using System.Collections;

public class Emitter : MonoBehaviour {

	public Rigidbody2D[] prefabs;
	public bool continuous = true;
	private float childWidth = 2.56f;
	public bool random = false;
	public float minDelay = 1.0f;
	public float maxDelay = 2.0f;

	private float timeCounter = 0.0f;
	private float timeTarget;

	public Rigidbody2D instance;


	private float OffsetX;

	// Use this for initialization
	void Start () {
		OffsetX = transform.position.x - Camera.main.transform.position.x;
		if (random) {
			SetTime();
		}
		if (continuous) {
			childWidth = prefabs [Random.Range (0, prefabs.Length)].GetComponent<SpriteRenderer>().bounds.size.x;
			if(instance == null){
				AddContinuous();
			}
		}
	}

	void SetTime(){
		timeTarget = Random.Range(minDelay*100, maxDelay*100)/100;
	}

	void AddContinuous(){
		float childX = transform.position.x;
		if (instance != null) {
			childX = instance.transform.position.x + childWidth;
		}
		instance = (Rigidbody2D)Instantiate (prefabs[Random.Range(0,prefabs.Length)], new Vector2 (childX, transform.position.y), transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2(Camera.main.transform.position.x + OffsetX, transform.position.y);
		//print (transform.position);
		if (continuous) {
			if (transform.position.x >= instance.position.x) {
				AddContinuous();
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
