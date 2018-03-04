using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FllowTarget : MonoBehaviour {

    public Transform PlayerTransform;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - PlayerTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = PlayerTransform.position + offset;
	}
}
