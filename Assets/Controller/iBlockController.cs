using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class iBlockController : NetworkBehaviour {

	[SyncVar]
	public bool isSelected = false;

	private Vector3 defaultPosition;

	// Use this for initialization
	void Start () {
		 defaultPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (isSelected) {
			transform.position = Vector3.Lerp(transform.position, defaultPosition + new Vector3(0, 1, 0), Time.deltaTime * 5.0f);
			GetComponent<MeshRenderer>().material.color = Color.gray;
		} else {
			transform.position = Vector3.Lerp(transform.position, defaultPosition, Time.deltaTime * 5.0f);
			GetComponent<MeshRenderer>().material.color = Color.white;
		}
	}
}
