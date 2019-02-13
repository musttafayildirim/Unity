using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifElse : MonoBehaviour {

    int can = 100;
	void Start () {
        
	}
	
	void Update () {
        if (Input.GetMouseButtonDown(0) && can>0)
        {
            can = can - 10;
            Debug.Log(can);

            if(can == 0)
            {
                Debug.Log("GAME OVER");
            }
        }

       

	}
}
