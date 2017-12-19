using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator : MonoBehaviour {

	public GameObject[] clouds;
	public float minY;
	public float maxY;
	public float minSpeed;
	public float maxSpeed;
	public float minScale;
	public float maxScale;
	public float interval;
	
	void Start () {
		InvokeRepeating("Spawn",0,interval);
	}
	
	void Spawn () {
		GameObject cloud = clouds[Random.Range(0,clouds.Length)];
		Vector2 pos = new Vector2(transform.position.x,Random.Range(minY,maxY));
		float scl = Random.Range(minScale,maxScale);
		Vector3 scale = new Vector3(scl,scl,scl);
		float speed = Random.Range(minSpeed,maxSpeed);

		GameObject s = Instantiate(cloud,pos,Quaternion.identity) as GameObject;
		s.GetComponent<MoveObj>().Speed = speed;
		s.transform.localScale = scale;
		
	}
}