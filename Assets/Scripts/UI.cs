using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.transform.position.x + " " + hit.collider.transform.position.z);
                int x = (int)hit.collider.transform.position.x;
                int y = (int)hit.collider.transform.position.z;
                GameObject go = GameObject.Find("Map");
                Map map = go.GetComponent<Map>();
                map.UpdateTile(x, y);
                
            }

        }
    }
}
