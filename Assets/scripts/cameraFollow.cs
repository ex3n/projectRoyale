using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {
    public GameObject player;
    public int cameraHeight;
    public int camShiftZ;
    private Vector3 offset;
    private Vector3 camOffset;
    // Use this for initialization
    void Start () {
        offset = transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        camOffset = player.transform.position;
        camOffset.y = cameraHeight;
        camOffset.z += camShiftZ;
        transform.position = camOffset;
    }
}
