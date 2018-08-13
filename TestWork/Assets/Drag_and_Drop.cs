using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_and_Drop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    
    public int Podset;
    GameObject Bear;
    Vector3 ItemPos;
    Vector3 DropPos;
    public CustomizeB Var;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Bear = GameObject.Find("BearMesh");
        Var = Bear.GetComponent<CustomizeB>();
        DropPos = GameObject.Find("DropArea").transform.position;
        ItemPos = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (transform.position.x <= DropPos.x+90 && transform.position.x >= DropPos.x - 90 && transform.position.y<= DropPos.y+90 && transform.position.y >= DropPos.y - 90)
        {           
            transform.position = ItemPos;
            Var.CustSet = Podset;
        }
        transform.position = ItemPos;
    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

    }
}
