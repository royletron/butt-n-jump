using UnityEngine;
using System.Collections;

public class Collector : MonoBehaviour {

	private float OffsetX;

	// Use this for initialization
	void Start () {
		OffsetX = transform.position.x - Camera.main.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2(Camera.main.transform.position.x + OffsetX, transform.position.y);
		GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
		foreach(GameObject thisObject in allObjects){
			if (thisObject.activeInHierarchy){
				if (thisObject.transform.position.x < this.transform.position.x)
				{
					Destroy (thisObject);
					//destroy?
				}
			}
		}
	}
}
