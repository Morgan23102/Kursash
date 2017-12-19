using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {

	public int Life_points;
	public float Speed;
	public float minY;
	public float maxY;
	public float minX;
	public float maxX;
	public GameObject bullet;
	public float shootDelay;
	public Transform[] shootPoints;
	public bool isFire;
	public bool isReadyToShoot;
	public int bulletDmg;

	void Start() { 
		isReadyToShoot = true;
		isFire = false;
	}
	
	void Update() {
		Vector2 curPos = transform.localPosition;
		curPos.y = Mathf.Clamp(transform.localPosition.y,minY,maxY);
		curPos.x = Mathf.Clamp(transform.localPosition.x,minX,maxX);
		transform.localPosition = curPos;
		
		if(isFire && isReadyToShoot){
			Shoot();
		}
	}
	
	public void Move (Vector2 dir) {
		transform.Translate(dir*Time.deltaTime*Speed);
	}
	
	void Shoot(){
		foreach(Transform sp in shootPoints){
			GameObject b = Instantiate(bullet, sp.position, Quaternion.identity) as GameObject;
			if(sp == shootPoints[shootPoints.Length-1]){
				StartCoroutine(ShootDelay());
				}
			}
		
	}
	IEnumerator ShootDelay(){
		isReadyToShoot = false;
		yield return new WaitForSeconds(shootDelay);
		isReadyToShoot = true;
	}
	public void Fire(bool fire){
		isFire = fire;
	}
	
	void Damage(int dmg){
		Life_points -= dmg;
		if(Life_points < 0){
			Life_points = 0;
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.CompareTag("enemyB")){
			Damage(1);
			Destroy(coll.gameObject);
		}
	}
}
