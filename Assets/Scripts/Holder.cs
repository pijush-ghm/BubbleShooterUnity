using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
    [SerializeField]
    private Bubble BubblePrefab;

    public void PopulateBubbles()
    {
        float y = 9.35f;

        for (int r = 0; r < 8; r++)
        {
            float x = 0.25f + 0.2f;

            int length = (r + 1) % 2 == 0 ? 9 : 10;

            x = (length == 9) ? x + 0.25f : x;

            for (int c = 0; c < length; c++)
            {
                Bubble bubble = Instantiate(BubblePrefab, transform);

                bubble.transform.position = new Vector2(x, y);

                bubble.ApplyRandomColor();

                bubble.ActivateCollider = true;

                x += 0.5f;
            }

            y -= 0.44f;
        }
    }
}
