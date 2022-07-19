using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTiles : MonoBehaviour
{
    [SerializeField] private Animator greenTileDown;

    public void MoveThisGameObject()
    {
        if (this.gameObject.tag == "Red")
        {
            // Below code animates red tiles in row 2.
            if (transform.position.x == 0 && transform.position.y == 7)
            {
                greenTileDown.Play("c1-r2");
            }

            if (transform.position.x == 6 && transform.position.y == 7)
            {
                greenTileDown.Play("c2-r2");
            }

            if (transform.position.x == 12 && transform.position.y == 7)
            {
                greenTileDown.Play("c3-r2");
            }

            if (transform.position.x == 18 && transform.position.y == 7)
            {
                greenTileDown.Play("c4-r2");
            }

            // Below code animates red tiles in row 3.
            if (transform.position.x == 0 && transform.position.y == 14)
            {
                greenTileDown.Play("c1-r3");
            }

            if (transform.position.x == 6 && transform.position.y == 14)
            {
                greenTileDown.Play("c2-r3");
            }

            if (transform.position.x == 12 && transform.position.y == 14)
            {
                greenTileDown.Play("c3-r3");
            }

            if (transform.position.x == 18 && transform.position.y == 14)
            {
                greenTileDown.Play("c4-r3");
            }
        }

        if (this.gameObject.tag == "Amber")
        {
            // Below code animates amber tiles in row 2.
            if (transform.position.x == 0 && transform.position.y == 7)
            {
                greenTileDown.Play("c1-r2");
            }

            if (transform.position.x == 6 && transform.position.y == 7)
            {
                greenTileDown.Play("c2-r2");
            }

            if (transform.position.x == 12 && transform.position.y == 7)
            {
                greenTileDown.Play("c3-r2");
            }

            if (transform.position.x == 18 && transform.position.y == 7)
            {
                greenTileDown.Play("c4-r2");
            }

            // Below code animates amber tiles in row 3.
            if (transform.position.x == 0 && transform.position.y == 14)
            {
                greenTileDown.Play("c1-r3");
            }

            if (transform.position.x == 6 && transform.position.y == 14)
            {
                greenTileDown.Play("c2-r3");
            }

            if (transform.position.x == 12 && transform.position.y == 14)
            {
                greenTileDown.Play("c3-r3");
            }

            if (transform.position.x == 18 && transform.position.y == 14)
            {
                greenTileDown.Play("c4-r3");
            }
        }

        if (this.gameObject.tag == "Green")
        {
            // Below code animates green tiles in row 1.
            if (transform.position.x == 0 && transform.position.y == 0)
            {
                greenTileDown.Play("c1-r1");
            }

            if (transform.position.x == 6 && transform.position.y == 0)
            {
                greenTileDown.Play("c2-r1");
            }

            if (transform.position.x == 12 && transform.position.y == 0)
            {
                greenTileDown.Play("c3-r1");
            }

            if (transform.position.x == 18 && transform.position.y == 0)
            {
                greenTileDown.Play("c4-r1");
            }

            // Below code animates green tiles in row 2.
            if (transform.position.x == 0 && transform.position.y == 7)
            {
                greenTileDown.Play("c1-r2");
            }
            
            if (transform.position.x == 6 && transform.position.y == 7)
            {
                greenTileDown.Play("c2-r2");
            }

            if (transform.position.x == 12 && transform.position.y == 7)
            {
                greenTileDown.Play("c3-r2");
            }

            if (transform.position.x == 18 && transform.position.y == 7)
            {
                greenTileDown.Play("c4-r2");
            }

            // Below code animates green tiles in row 3.
            if (transform.position.x == 0 && transform.position.y == 14)
            {
                greenTileDown.Play("c1-r3");
            }

            if (transform.position.x == 6 && transform.position.y == 14)
            {
                greenTileDown.Play("c2-r3");
            }

            if (transform.position.x == 12 && transform.position.y == 14)
            {
                greenTileDown.Play("c3-r3");
            }

            if (transform.position.x == 18 && transform.position.y == 14)
            {
                greenTileDown.Play("c4-r3");
            }
        }

        //transform.position = new Vector2(transform.position.x, transform.position.y - 7);

        /*if (transform.position.y < 0)
        {
            Destroy(this.gameObject);
        }*/
    }
}
