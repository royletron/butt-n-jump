using UnityEngine;
using System.Collections;

public class StartingVelocity : MonoBehaviour {

	public float VelocityX = 0.0f;
	public float VelocityY = 0.0f;

	// Use this for initialization
	void Start () {
		Rigidbody2D m_Rigidbody2D = GetComponent<Rigidbody2D>();
		m_Rigidbody2D.velocity = new Vector2 (VelocityX, VelocityY);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
