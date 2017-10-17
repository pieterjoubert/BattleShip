using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {

    public enum States { Open, Ship, Missed, Hit };

    public States State { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Direction { get; set; } //0 = left-right, 1 = up-down

}
