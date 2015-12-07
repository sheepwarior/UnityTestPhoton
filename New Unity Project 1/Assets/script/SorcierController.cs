using UnityEngine;
using System.Collections;

public class SorcierController : MonoBehaviour {

    float speed = 1000f;
    PhotonView view;

	// Use this for initialization
	void Start () {
        view = GetComponent<PhotonView>();
	}
	
	
	void FixedUpdate () {
        //get the inputs
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0.0f, v);

        if (h != 0f || v != 0f) // else the falling is really slow 
        {
            if (view.isMine)
            {
                GetComponent<Rigidbody>().velocity = movement * speed * Time.deltaTime;
            }
        }
            
    }
    // Update is called once per frame
    void Update() {
    }

}
