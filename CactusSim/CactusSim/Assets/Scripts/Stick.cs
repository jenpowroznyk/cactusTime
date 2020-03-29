using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
	//public GameObject decoration;

	public Transform decorationTransform;
	private Transform spikeTransform;


	private Rigidbody decorationRB;
	private GameObject spikeObj;
	private bool isOnSpike;

	//private Transform spikeTransform;

	// Start is called before the first frame update
	void Start()
    {
		isOnSpike = false;
		decorationRB = gameObject.GetComponent<Rigidbody>();
		decorationTransform = gameObject.GetComponent<Transform>();
	}

    // Update is called once per frame
    void Update()
    {
        if(isOnSpike)
		{
			
			Vector3 spikeX = spikeTransform.position;

			Debug.Log(spikeTransform.position);

			decorationTransform.position = spikeX;

		}
    }

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Spike"))
		{
			// stop decor from moving
			decorationRB.velocity = Vector3.zero;
			//decorationRB.useGravity = false;
			decorationRB.isKinematic = true; 
			//decorationRB.constraints =  RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;

			//get spike position
			spikeObj = collision.gameObject;

			spikeTransform = spikeObj.GetComponentInChildren<Transform>();

			decorationTransform.SetParent(spikeTransform);


			isOnSpike = true;

			//decorationTransform 
			Debug.Log("collided");

		}
	}
}
