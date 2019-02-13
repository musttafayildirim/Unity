using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topControl : MonoBehaviour {

    Rigidbody fizik;
    public int hiz;
    public int toplanacakNesne;
    int sayac=0;

    public Text sayacText;
    public Text oyunBittiText;


	void Start () {
        fizik = GetComponent<Rigidbody>();
	}
	
	
	void FixedUpdate () {

        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vec*hiz);


	}

    private void OnTriggerEnter(Collider other)
    {
//OnTriggerEnter  OnTriggerStay   OnTriggerExit            
        if(other.gameObject.tag=="engel")
        {
            other.gameObject.SetActive(false);
            sayac++;
            sayacText.text = "Sayac = " + sayac;
        }
        if (sayac == toplanacakNesne)
        {

            oyunBittiText.text = "OYUN BİTTİ";
        }
    }
}
