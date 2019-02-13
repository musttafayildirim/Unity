using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diziler : MonoBehaviour {
    public string []isimler;
	// Use this for initialization
	void Start () {
        int[] dizi = { 100, 250, 250, 10, 111, 256,100, 363};

        for(int i = 0; i < dizi.Length; i++)
        {
            Debug.Log(dizi[i]);
        }

        
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < isimler.Length; i++)
        {
            Debug.Log(isimler[i]);
        }
    }
}
