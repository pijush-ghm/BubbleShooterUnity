using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{
    public Vector2 Value;

    public bool CanThrow { get { return gameObject.activeSelf; } }

    public void Movement()
    {
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (worldMousePos.y > 2.25f)
        {
            Vector2 distance = worldMousePos - transform.position;

            var angle = Mathf.Atan2(distance.y, distance.x);

            gameObject.SetActive(true);

            transform.localRotation = Quaternion.Euler(0, 0, (Mathf.Rad2Deg * angle) - 90);

            Value = distance.normalized;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
