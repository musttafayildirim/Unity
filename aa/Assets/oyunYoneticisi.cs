using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunYoneticisi : MonoBehaviour {
    GameObject donenCember;
    GameObject anaCember;
    // Use this for initialization
    void Start() {
        donenCember = GameObject.FindGameObjectWithTag("donenCemberTag");
        anaCember = GameObject.FindGameObjectWithTag("anaCemberTag");

    }

    public void oyunBitti()
    {
        //donenCember compenentimin görünürlüğünü kapatıyorum...
        donenCember.GetComponent<dondurme>().enabled = false;
        anaCember.GetComponent<anaCember>().enabled = false;
    }
}