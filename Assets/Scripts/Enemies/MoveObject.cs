using UnityEngine;
using System.Collections;

public class MoveObj : MonoBehaviour {

public float Speed;
public Vector2 moveDir;
	
	void Update () {
	transform.Translate(moveDir*Time.deltaTime*Speed);
	}
}
