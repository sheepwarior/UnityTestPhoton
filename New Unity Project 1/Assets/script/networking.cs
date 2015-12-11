using UnityEngine;
using System.Collections;

public class networking : MonoBehaviour {

    private string _gameVersion = "0.1";
    public GameObject FinalBaseMesh;

    // Use this for initialization
    void Start () {
        PhotonNetwork.ConnectUsingSettings(_gameVersion);
	}
	
	// Update is called once per frame
	void Update () {
       // StatusText.text = ("Status :" + PhotonNetwork.connectionStateDetailed.ToString());
    }
    /*** methode de callback fourni dans la doc ***/
    void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    void OnJoinedLobby()
    {
        Debug.Log("try to join random room");
        PhotonNetwork.JoinRandomRoom();
    }
    void OnPhotonRandomJoinFailed()
    {
        Debug.Log("fail to join random room so let's create a new one");
        PhotonNetwork.CreateRoom(null);
    }
    void OnJoinedRoom()
    {
        Debug.Log("succed to join a room");
        PhotonNetwork.Instantiate ("Prefabs/" + FinalBaseMesh.name, FinalBaseMesh.transform.position, Quaternion.identity,0);
    }

}
