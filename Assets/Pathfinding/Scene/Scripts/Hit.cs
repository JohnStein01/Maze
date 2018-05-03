using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
	public GameObject HitText;
	// Use this for initialization
	void Start () {
		HitText.gameObject.SetActive (false);
	}

	void OnTriggerEnter(Collider c){
		if (c.gameObject.name == "Bullet") {			
			Destroy (c.gameObject);
			HitText.gameObject.SetActive (true);
		}		
	}
}
