using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class move : NetworkBehaviour {

    public Follow objectFollowingMe;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
            return;

        if (true)//objectFollowingMe.transform.position == transform.position)
        {
            //objectFollowingMe.StopMouvement();
            if (Input.GetKeyDown("w"))
                transform.position = new Vector2(transform.position.x, transform.position.y + 1);
            else if (Input.GetKeyDown("s"))
                transform.position = new Vector2(transform.position.x, transform.position.y - 1);
            else if(Input.GetKeyDown("a"))
                transform.position = new Vector2(transform.position.x - 1, transform.position.y);
            else if(Input.GetKeyDown("d"))
                transform.position = new Vector2(transform.position.x + 1, transform.position.y);
        }
    }
}
