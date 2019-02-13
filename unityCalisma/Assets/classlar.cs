using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classlar : MonoBehaviour {

	// Use this for initialization
	void Start () {
        mustafa mus = new mustafa();
        Debug.Log(mus.adi[0]);
        Debug.Log(mus.adi[1]);
        Debug.Log(mus.yasi);
        Debug.Log(mus.kilosu);
        Debug.Log(mus.boyu);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

class mustafa
{
    public string[] adi = { "Mustafa", "YILDIRIM" };

    public int yasi = 22;
    public int kilosu = 90;
    public float boyu = 1.87f; 
}
