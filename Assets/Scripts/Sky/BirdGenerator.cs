using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdGenerator : MonoBehaviour {

	public GameObject[] birds;
	public float minY;
	public float maxY;
	public float minSpeed;
	public float maxSpeed;
	public float minScale;
	public float maxScale;
	//public Color[] colors;
	public float interval;
	
	void Start () {
		InvokeRepeating("Spawn",0,interval);
	}
	
	void Spawn () {
		GameObject bird = birds[Random.Range(0,birds.Length)];
		Vector2 pos = new Vector2(transform.position.x,Random.Range(minY,maxY));
		float scl = Random.Range(minScale,maxScale);
		Vector3 scale = new Vector3(scl,scl,scl);
		float speed = Random.Range(minSpeed,maxSpeed);

		GameObject s = Instantiate(bird,pos,Quaternion.identity) as GameObject;
		s.GetComponent<MoveObj>().Speed = speed;
		s.transform.localScale = scale;

	}
}