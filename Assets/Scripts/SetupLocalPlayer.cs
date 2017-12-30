using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {

	string pname = "Player";

	void OnGUI () {
		if (isLocalPlayer) {
			pname = GUI.TextField (new Rect (25, Screen.height - 40, 100, 30), pname);
		}
	}

	// Use this for initialization
	void Start () {
		if (isLocalPlayer) {
			GetComponent<Drive> ().enabled = true;
		}
	}

	void Update () {
		if (isLocalPlayer) {
			this.GetComponentInChildren<TextMesh> ().text = pname;
		}
	}
}
