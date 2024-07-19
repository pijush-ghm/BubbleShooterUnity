using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    private Dictionary<int, Color> colorDic = new Dictionary<int, Color>()
    {
        { 0, new Color32(0,0,0,0) },
        { 1, Color.red },
        { 2, Color.green },
        { 3, Color.blue },
        { 4, Color.yellow },
        { 5, Color.magenta }
    };

    [SerializeField]
    private SpriteRenderer Circle;

    [SerializeField]
    private CircleCollider2D Collider;

    public int Row = -1, Col = -1;

    public int Value;

    public bool ActivateCollider { set { Collider.enabled = value; } }

    public void ApplyRandomColor()
    {
        Value = Random.Range(1, 6);

        Circle.color = colorDic[Value];
    }

    
}
