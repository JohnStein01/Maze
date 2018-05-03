using UnityEngine;
using System.Collections;

public class Aim : MonoBehaviour
{	
	public GameObject Target;
	public GameObject Bullet;

	void Start(){
		StartCoroutine(WaitAndShoot());
	}

	private IEnumerator WaitAndShoot(){		
		yield return new WaitForSeconds(21);
		transform.rotation = Quaternion.LookRotation (Target.transform.position);
		yield return new WaitForSeconds (2);
		Vector3 Deneme = Bullet.transform.position - Target.transform.position;
		Deneme.y = 0;
		Deneme.z = Deneme.z + 1.5f;
		Bullet.GetComponent<Rigidbody> ().velocity = Deneme;
	}
}