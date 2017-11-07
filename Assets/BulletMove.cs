using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
    private float timetodestroy;
    // Use this for initialization
    void Start () {
        timetodestroy = 3;
    }
	
	// Update is called once per frame
	void Update () {
        timetodestroy = timetodestroy - Time.deltaTime;
        gameObject.transform.position += transform.forward * Time.deltaTime * 10;
        if (timetodestroy < 0)
        {
            Destroy(gameObject);
        }
    }
}
