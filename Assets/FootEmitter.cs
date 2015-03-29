using UnityEngine;
using System.Collections;

public class FootEmitter : MonoBehaviour {

	private bool emitted = false;
	public bool emit = false;
	// Use this for initialization
	void Start () {
		emitted = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(emit && !emitted)
		{
			emitted = true;
			print (this.GetComponentInParent<Transform> ().position.x);
		}
		if (!emit && emitted) 
		{
			emitted = false;
		}
	}
}
