using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class lobbyScript : MonoBehaviour {

    public Text startTimer;

    public NetworkManager nm;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		startTimer.text = nm.numPlayers.ToString();
        
    }
}
