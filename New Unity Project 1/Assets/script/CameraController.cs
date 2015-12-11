using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    PhotonView view;
    Transform MainCamera;
    Transform Sorcier;
    public GameObject MainCamera2;
    // Use this for initialization
    void Start () {
        view = GetComponent<PhotonView>();
        MainCamera = GameObject.Find("Main Camera").GetComponent<Transform>();
        Sorcier = GameObject.Find("Sorcier").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        MainCamera.position.Equals(Sorcier);
    }
}
