using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    [SerializeField]
    private Holder Holder;

    [SerializeField]
    private Launcher Launcher;

    [SerializeField]
    private Direction Direction;    

    void Start()
    {
        Holder.PopulateBubbles();

        Launcher.SpawnBubbles();
    }

    private void Update()
    {
        Direction.Movement();

        Launcher.Throw(Direction);        
    }
}
