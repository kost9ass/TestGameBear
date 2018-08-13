using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeB : MonoBehaviour {

    public Material[] Mat = new Material[8];
    public GameObject Body;
    public GameObject[] UFoot = new GameObject[2];
    public GameObject[] DFoot = new GameObject[2];
    public GameObject Galst;
    Animator Anim;
    Material matm;
    int AnimDrag;
    public int CustSet;
    // Use this for initialization
    void Start () {               
        Anim = GetComponent<Animator>();
        Galst.SetActive(false);
        //rend = Bear.GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if(CustSet == 1 || CustSet == 2)
        {
            AnimDrag = 1;
            if (CustSet == 1)
            {
                Body.GetComponent<Renderer>().material = Mat[0];              
            }
            if (CustSet == 2)
            {
                Body.GetComponent<Renderer>().material = Mat[1];
            }
            CustSet = 0;
        }
        if (CustSet == 3 || CustSet == 4)
        {
            AnimDrag = 2;
            if (CustSet == 3)
            {
                UFoot[0].GetComponent<Renderer>().material = Mat[2];
                UFoot[1].GetComponent<Renderer>().material = Mat[2];
                DFoot[0].GetComponent<Renderer>().material = Mat[4];
                DFoot[1].GetComponent<Renderer>().material = Mat[4];
            }
            if (CustSet == 4)
            {
                UFoot[0].GetComponent<Renderer>().material = Mat[3];
                UFoot[1].GetComponent<Renderer>().material = Mat[3];
                DFoot[0].GetComponent<Renderer>().material = Mat[5];
                DFoot[1].GetComponent<Renderer>().material = Mat[5];
            }
            CustSet = 0;
        }
        if (CustSet == 5 || CustSet == 6)
        {
            AnimDrag = 3;
            if (CustSet == 5)
            {
                Galst.SetActive(true);
                Galst.GetComponent<Renderer>().material = Mat[6];
            }
            if (CustSet == 6)
            {
                Galst.SetActive(true);
                Galst.GetComponent<Renderer>().material = Mat[7];
            }
            CustSet = 0;
        }
        if (AnimDrag == 1)
        {   
            Anim.Play("BodyAn");
            AnimDrag = 0;
        }
        if (AnimDrag == 2)
        {
            Anim.Play("FootAn");
            AnimDrag = 0;
        }
        if (AnimDrag == 3)
        {
            Anim.Play("GalstAn");
            AnimDrag = 0;
        }

    }
}
