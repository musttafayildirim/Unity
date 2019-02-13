using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donguler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for(int i = 0; i < 50; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i + " bu sayı çifttir.");
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
