using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukCemberCode : MonoBehaviour {

    Rigidbody2D fizik;
    public float hiz;
    bool hareketKontrol = false;
    GameObject oyunYoneticisi;
	void Start () {
        //bu obje oluştuğunda obje hareket edecek...
        fizik = GetComponent < Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunYoneticisiTag");
	}
	
	
	void FixedUpdate () {
        //çarpışma olduğunda hareket etmesi için
        if (!hareketKontrol)
        {
            //moveposition vektor 2 alıyor..
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }


	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "donenCemberTag")
        {
            transform.SetParent(collision.transform);
            hareketKontrol = true;
        }
        if (collision.tag == "kucukCemberTag")
        {
            oyunYoneticisi.GetComponent<oyunYoneticisi>().oyunBitti();
        }
    }
}
