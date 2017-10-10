using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    Tile[,] map = new Tile[10, 10];
    public GameObject open;
    public GameObject hit;
    public GameObject miss;


	// Use this for initialization
	void Start () {
        for(int x = 0; x < 10; x++)
        {
            for(int y = 0; y < 10; y++)
            {
                if(Random.Range(0f,100f) < 10)
                {
                    Tile t = new Tile();
                    t.State = Tile.States.Ship;
                    t.X = x;
                    t.Y = y;
                    map[x, y] = t;
                }
                else
                {
                    Tile t = new Tile();
                    t.State = Tile.States.Open;
                    t.X = x;
                    t.Y = y;
                    map[x, y] = t;
                }
            }
        }
        Redraw();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Redraw()
    {
        foreach(Tile t in map)
        {
            if(t.State == Tile.States.Open)
            {
                Instantiate(open, new Vector3(t.X, 0f, t.Y), Quaternion.identity);
            }
            else if(t.State == Tile.States.Ship)
            {
                Instantiate(hit, new Vector3(t.X, 0f, t.Y), Quaternion.identity);
            }
        }
    }
}
