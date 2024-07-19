using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Launcher : MonoBehaviour
{
    [SerializeField]
    private Bubble BubblePrefab;

    private Bubble[] _bubbleArray = new Bubble[2];

    private int _selected = 0;
    
    public void SpawnBubbles()
    {
        Vector2[] bubblePosArray = new Vector2[] { new Vector2(0, 0.6f), new Vector2(0, -0.6f) };

        for (int i = 0; i < 2; i++)
        {
            if (_bubbleArray[i] == null)
            {
                Bubble bubble = Instantiate(BubblePrefab, transform);
                bubble.transform.localPosition = bubblePosArray[i];
                bubble.ApplyRandomColor();
                bubble.ActivateCollider = false;
                _bubbleArray[i] = bubble;
            }
        }
    }

    public void Throw(Direction direction)
    {
        if (direction.CanThrow && Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(_bubbleArray[_selected].transform.position, direction.Value, 10);

            if (hit.collider != null)
            {
                Debug.Log(hit.collider.tag);

                
            }

            /*DestroyImmediate(_bubbleArray[_selected].gameObject);

            transform.DOBlendableRotateBy(new Vector3(0, 0, -180), 0.25f).SetEase(Ease.InOutFlash).OnComplete(() => {
                SpawnBubbles();
                _selected = (_selected == 0) ? 1 : 0;
            });*/
        }                
    }
}
