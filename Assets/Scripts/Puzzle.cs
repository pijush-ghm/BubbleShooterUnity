using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    [SerializeField]
    private GameObject BubblePrefab;

    [SerializeField]
    private GameObject BubbleHolder;

    [SerializeField]
    private GameObject Direction;

    public enum BubbleTypes { RED, GREEN, BLUE, YELLOW, MAGENTA };

    public Dictionary<BubbleTypes, Color> BubbleColors = new Dictionary<BubbleTypes, Color>() {
        { BubbleTypes.RED, Color.red },
        { BubbleTypes.GREEN, Color.green },
        { BubbleTypes.BLUE, Color.blue },
        { BubbleTypes.YELLOW, Color.yellow },
        { BubbleTypes.MAGENTA,Color.magenta }
    };

    private List<List<Bubble>> _arrayList;

    void Start()
    {
                
    }

    private void Update()
    {
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (worldMousePos.y > 2.25f)
        {
            Vector2 distance = worldMousePos - Direction.transform.position;

            var angle = Mathf.Atan2(distance.y, distance.x);

            Direction.SetActive(true);

            Direction.transform.localRotation = Quaternion.Euler(0, 0, (Mathf.Rad2Deg * angle) - 90);
        }
        else
        {
            Direction.SetActive(false);
        }     
    }

    private void DrawBubbles()
    {
        float y = 9.35f;

        for (int r = 0; r < 20; r++)
        {
            float x = 0.25f + 0.2f;

            int length = (r + 1) % 2 == 0 ? 9 : 10;

            x = (length == 9) ? x + 0.25f : x;

            for (int c = 0; c < length; c++)
            {
                GameObject bubble = Instantiate(BubblePrefab, BubbleHolder.transform);

                bubble.transform.position = new Vector2(x, y);

                x += 0.5f;
            }

            y -= 0.44f;
        }
    }

}
