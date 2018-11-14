using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public GameObject objectToFollow;
    public float walkSpeed = 1f;
    public float t;

    Vector3 startPos;
    Vector3 endPos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (endPos != objectToFollow.transform.position)
        {
            StartCoroutine(Move(transform));

        }
            
	}

    public IEnumerator Move(Transform entity)
    {
        t = 0;
        startPos = entity.position;
        endPos = objectToFollow.transform.position;



        while (t < 1f)
        {
            t += Time.deltaTime * walkSpeed;
            entity.position = Vector3.Lerp(startPos, endPos, t);
            yield return null;
        }
        yield return 0;
    }
    public void StopMouvement()
    {
        StopAllCoroutines();
    }
}
