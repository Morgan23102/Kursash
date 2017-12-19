using UnityEngine;
using System.Collections;

public class MoveSun : MonoBehaviour {
	public float angle;
	public float radius;
    public float speed;
	public GameObject BackgroundDay;
	public GameObject BackgroundNight;
	

	void Update() {
        angle += Time.deltaTime;
			if (angle>60){
				angle=0;
			}
			if(angle>0 && angle<30){
				BackgroundDay.SetActive(true);
				BackgroundNight.SetActive(false);
			}
			if(angle>30 && angle<60){
				BackgroundDay.SetActive(false);
				BackgroundNight.SetActive(true);
			}
		float x = Mathf.Cos (angle * speed) * radius;
        float y = Mathf.Sin (angle * speed) * radius;
        transform.position = new Vector2(3*x, 2*y-2);
    }
}
