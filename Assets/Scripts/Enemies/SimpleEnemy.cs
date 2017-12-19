using UnityEngine;
using System.Collections;

public class SimpleEnemy : MonoBehaviour {

	public int Life_points;
	public GameObject bullet;
	public float shootDelay;
	public Transform shootPoint;
	public PlaneController Plane;

	void Start(){
		Plane = GameObject.Find("PlanePlayer").GetComponent<PlaneController>();
		InvokeRepeating("Shoot" ,2 ,shootDelay);
	}

	void Shoot(){
		GameObject b = Instantiate(bullet, shootPoint.position, Quaternion.identity) as GameObject;
	}

	void Damage(int dmg){
		Life_points -= dmg;
		if(Life_points < 0){
			Life_points = 0;
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.CompareTag("planeB")){
			Damage(Plane.bulletDmg);
			Destroy(coll.gameObject);
		}
	}
}
