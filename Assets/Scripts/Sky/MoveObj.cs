using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

	public float Speed;
	public Vector2 dir;

	// Update is called once per frame
	void Update () {
	transform.Translate(dir*Speed*Time.deltaTime,Space.World);
	}
}
