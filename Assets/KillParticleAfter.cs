using UnityEngine;
using System.Collections;

public class KillParticleAfter : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		Destroy (gameObject, 0.5f);
	}
}
