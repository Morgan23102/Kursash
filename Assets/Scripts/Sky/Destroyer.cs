using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	
	void Update () {
		if(transform.position.x <=-10)
			{
			Destroy(gameObject);
		}
	}
}