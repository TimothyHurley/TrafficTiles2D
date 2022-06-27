using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTiles : MonoBehaviour
{
    public void MoveThisGameObject()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - 7);

        if (transform.position.y < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
