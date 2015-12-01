using UnityEngine;
using System.Collections;

public class RandomMatchmarker : Photon.PunBehaviour {

	// Use this for initialization
	void Start () {

		PhotonNetwork.ConnectUsingSettings ("0.1");
	
	}

	public override void OnJoinedLobby ()
	{
		PhotonNetwork.JoinRandomRoom ();
	}

	void OnPhotonRandomJoinFailed(){
	
		Debug.Log ("Can't join random room!");
		PhotonNetwork.CreateRoom (null);
	}

	void OnJoinedRoom(){
	
		GameObject monster = PhotonNetwork.Instantiate ("monsterprefab", Vector3.zero, Quaternion.identity, 0);
		monster.GetComponent<myThirdPersonController>().isControllable = true;
	}

	void OnGUI(){

		GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
