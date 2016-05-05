using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer) {
			return;
		}

		if (Input.GetKeyDown ("1")) {
			CmdMoveBlockWithId (1);
		}
		if (Input.GetKeyDown ("2")) {
			CmdMoveBlockWithId (2);
		}
		if (Input.GetKeyDown ("3")) {
			CmdMoveBlockWithId (3);
		}	
		if (Input.GetKeyDown ("4")) {
			CmdMoveBlockWithId (4);
		}
		if (Input.GetKeyDown ("5")) {
			CmdMoveBlockWithId (5);
		}
		if (Input.GetKeyDown ("6")) {
			CmdMoveBlockWithId (6);
		}
		if (Input.GetKeyDown ("7")) {
			CmdMoveBlockWithId (7);
		}	
		if (Input.GetKeyDown ("8")) {
			CmdMoveBlockWithId (8);
		}
		if (Input.GetKeyDown ("9")) {
			CmdMoveBlockWithId (9);
		}	
	}

	[Command]
	void CmdMoveBlockWithId(int id) {
		string blockName = "iBlock" + (id - 1).ToString();
		GameObject block = GameObject.Find (blockName);
		block.GetComponent<iBlockController> ().isSelected = !block.GetComponent<iBlockController> ().isSelected;
		Debug.Log (block.ToString());	
	}
}
