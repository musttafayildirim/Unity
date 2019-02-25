using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    Rigidbody2D fizik;

    //[SerializeField] şeklinde kullanırsak aşağıdaki nesne private olsa bile inspector panelinde gözükür..
    //eğer açıklama yazmak istersek 
    [Tooltip("Buradan hızı ayarla")]
    public float hiz;
    private bool sagaBak;

	// Use this for initialization
	void Start () {
        fizik = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update () {
        float yatay = Input.GetAxis("Horizontal");
        temelHareketler(yatay);
        yonCevir(yatay);
    }

    private void temelHareketler(float yatay)
    {
        fizik.velocity = new Vector2(yatay * hiz, fizik.velocity.y);
    }

    private void yonCevir(float yatay)
    {
        if(yatay<0 && sagaBak || yatay>0 && !sagaBak)
        {
            sagaBak = !sagaBak;

            Vector3 yon = transform.localScale;

            yon.x *= -1;

            transform.localScale = yon;
        }
    }
}
