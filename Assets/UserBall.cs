using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserBall : MonoBehaviour {

    public GameObject bullet;
    Vector3 closestPos;
    float closestDist;
    // Use this for initialization
    void Start () {
        closestPos = transform.position;
        closestDist = float.MaxValue;
    }


    int frameCount = 0;
    const int frameReset = 6;
    // Update is called once per frame
    void Update () {
        
        if (true &&  //TODO check image detected
            frameCount % frameReset == 0)
        {
            string logMsg = "";

            Transform pos = transform;
            Vector3 testVec = pos.position;

            Camera mainCam = Camera.main;
            float dist = Vector3.Distance(mainCam.transform.position, testVec);
            if (dist < closestDist)
            {
                closestPos = testVec;
                closestDist = dist;
            }
            else if(Vector3.Distance(closestPos, testVec) > 0.8f)
            {
                logMsg = "shoot";
                closestPos = testVec;
                closestDist = dist;
                Instantiate(bullet, mainCam.transform.position, mainCam.transform.rotation);
                
            }

            //logMsg += " (" + testVec.x + "," + testVec.y + "," + testVec.z + ")";
            if (logMsg != "")
            {
                Debug.Log(logMsg);
            }
        }
        frameCount = (frameCount + 1) % frameReset;
    }
}
