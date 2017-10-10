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
                
                    Tile t = new Tile();
                    t.State = Tile.States.Open;
                    t.X = x;
                    t.Y = y;
                    map[x, y] = t;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            int xPos = Random.Range(0, 9);
            int yPos = Random.Range(0, 9);
            if (xPos + i + 1 < 9 && yPos + i + 1 < 9)
            { 
                for (int j = 0; j < i + 1; j++)
                {
                    map[xPos + j, yPos].X = xPos + j;
                    map[xPos + j, yPos].Y = yPos;
                    map[xPos + j, yPos].State = Tile.States.Ship;
                }
            }
            else
            {
                i--;
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
