using UnityEngine;
using System.Collections;

public class FootEmitter : MonoBehaviour {

	private bool emitted = false;
	public bool emit = false;

	public ParticleSystem emission;

	// Use this for initialization
	void Start () {
		emitted = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(emit && !emitted)
		{
			emitted = true;
			ParticleSystem instance = (ParticleSystem)Instantiate(emission);
			instance.transform.position = this.transform.position;
		}
		if (!emit && emitted) 
		{
			emitted = false;
		}
	}
}
