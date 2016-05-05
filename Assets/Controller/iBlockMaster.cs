using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class iBlockMaster : NetworkBehaviour {

	public int gridSizeX = 3;
	public int gridSizeY = 3;
	public int blockCount = 0;

	public GameObject iBlockPrefab;
	public GameObject[] list;

	// Use this for initialization
	void Start () {
		blockCount = gridSizeX * gridSizeY;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public override void OnStartServer() {
		int k = 0;
		for (int i = 0; i < gridSizeY; i++) {
			for (int j = 0; j < gridSizeX; j++) { 
				GameObject tmp = (GameObject) Instantiate(iBlockPrefab, new Vector3(i * 1.5f, 0, j * 1.5f), Quaternion.identity);
				tmp.name = "iBlock" + k;
				k++;
				ClientScene.RegisterPrefab (tmp);
				NetworkServer.Spawn(tmp);
			}
		}		
	}
}
