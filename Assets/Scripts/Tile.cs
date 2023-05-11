using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite[] tileGraphics;

    private void Start(){
        rend = GetComponent<SpriteRenderer>();
        int randTile =Random.Range(0, tileGraphics.Length);
        rend.sprite = tileGraphics [randTile];
    }
}
