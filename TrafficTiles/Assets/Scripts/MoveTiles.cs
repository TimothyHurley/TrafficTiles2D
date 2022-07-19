using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTiles : MonoBehaviour
{
    [SerializeField] private Animator tileFall;


    public void MoveThisGameObject()
    {
        if (this.gameObject.tag == "Red")
        {
            // Below code animates red tiles in row 2.
            if (transform.position.x == 0 && transform.position.y == 7)
            {
                tileFall.Play("c1-r2");
            }

            if (transform.position.x == 6 && transform.position.y == 7)
            {
                tileFall.Play("c2-r2");
            }

            if (transform.position.x == 12 && transform.position.y == 7)
            {
                tileFall.Play("c3-r2");
            }

            if (transform.position.x == 18 && transform.position.y == 7)
            {
                tileFall.Play("c4-r2");
            }

            // Below code animates red tiles in row 3.
            if (transform.position.x == 0 && transform.position.y == 14)
            {
                tileFall.Play("c1-r3");
            }

            if (transform.position.x == 6 && transform.position.y == 14)
            {
                tileFall.Play("c2-r3");
            }

            if (transform.position.x == 12 && transform.position.y == 14)
            {
                tileFall.Play("c3-r3");
            }

            if (transform.position.x == 18 && transform.position.y == 14)
            {
                tileFall.Play("c4-r3");
            }
            
            // Below code animates red tiles in row 4.
            if (transform.position.x == 0 && transform.position.y == 21)
            {
                tileFall.Play("c1-r4");
            }

            if (transform.position.x == 6 && transform.position.y == 21)
            {
                tileFall.Play("c2-r4");
            }

            if (transform.position.x == 12 && transform.position.y == 21)
            {
                tileFall.Play("c3-r4");
            }

            if (transform.position.x == 18 && transform.position.y == 21)
            {
                tileFall.Play("c4-r4");
            }

            // Below code animates red tiles in row 5.
            if (transform.position.x == 0 && transform.position.y == 28)
            {
                tileFall.Play("c1-r5");
            }

            if (transform.position.x == 6 && transform.position.y == 28)
            {
                tileFall.Play("c2-r5");
            }

            if (transform.position.x == 12 && transform.position.y == 28)
            {
                tileFall.Play("c3-r5");
            }

            if (transform.position.x == 18 && transform.position.y == 28)
            {
                tileFall.Play("c4-r5");
            }
        }

        if (this.gameObject.tag == "Amber")
        {
            // Below code animates amber tiles in row 2.
            if (transform.position.x == 0 && transform.position.y == 7)
            {
                tileFall.Play("c1-r2");
            }

            if (transform.position.x == 6 && transform.position.y == 7)
            {
                tileFall.Play("c2-r2");
            }

            if (transform.position.x == 12 && transform.position.y == 7)
            {
                tileFall.Play("c3-r2");
            }

            if (transform.position.x == 18 && transform.position.y == 7)
            {
                tileFall.Play("c4-r2");
            }

            // Below code animates amber tiles in row 3.
            if (transform.position.x == 0 && transform.position.y == 14)
            {
                tileFall.Play("c1-r3");
            }

            if (transform.position.x == 6 && transform.position.y == 14)
            {
                tileFall.Play("c2-r3");
            }

            if (transform.position.x == 12 && transform.position.y == 14)
            {
                tileFall.Play("c3-r3");
            }

            if (transform.position.x == 18 && transform.position.y == 14)
            {
                tileFall.Play("c4-r3");
            }
            
            // Below code animates amber tiles in row 4.
            if (transform.position.x == 0 && transform.position.y == 21)
            {
                tileFall.Play("c1-r4");
            }

            if (transform.position.x == 6 && transform.position.y == 21)
            {
                tileFall.Play("c2-r4");
            }

            if (transform.position.x == 12 && transform.position.y == 21)
            {
                tileFall.Play("c3-r4");
            }

            if (transform.position.x == 18 && transform.position.y == 21)
            {
                tileFall.Play("c4-r4");
            }

            // Below code animates amber tiles in row 5.
            if (transform.position.x == 0 && transform.position.y == 28)
            {
                tileFall.Play("c1-r5");
            }

            if (transform.position.x == 6 && transform.position.y == 28)
            {
                tileFall.Play("c2-r5");
            }

            if (transform.position.x == 12 && transform.position.y == 28)
            {
                tileFall.Play("c3-r5");
            }

            if (transform.position.x == 18 && transform.position.y == 28)
            {
                tileFall.Play("c4-r5");
            }
        }

        if (this.gameObject.tag == "Green")
        {
            /*// Below code animates green tiles in row 0.
            if (transform.position.x == 0 && transform.position.y == -7)
            {
                tileFall.Play("c1-r0");
                Destroy(this.gameObject);
            }

            if (transform.position.x == 6 && transform.position.y == -7)
            {
                tileFall.Play("c2-r0");
                Destroy(this.gameObject);
            }

            if (transform.position.x == 12 && transform.position.y == -7)
            {
                tileFall.Play("c3-r0");
                Destroy(this.gameObject);
            }

            if (transform.position.x == 18 && transform.position.y == -7)
            {
                tileFall.Play("c4-r0");
                Destroy(this.gameObject);
            }*/

            // Below code animates green tiles in row 1.
            if (transform.position.x == 0 && transform.position.y == 0)
            {
                tileFall.Play("c1-r1");
            }

            if (transform.position.x == 6 && transform.position.y == 0)
            {
                tileFall.Play("c2-r1");
            }

            if (transform.position.x == 12 && transform.position.y == 0)
            {
                tileFall.Play("c3-r1");
            }

            if (transform.position.x == 18 && transform.position.y == 0)
            {
                tileFall.Play("c4-r1");
            }

            // Below code animates green tiles in row 2.
            if (transform.position.x == 0 && transform.position.y == 7)
            {
                tileFall.Play("c1-r2");
            }
            
            if (transform.position.x == 6 && transform.position.y == 7)
            {
                tileFall.Play("c2-r2");
            }

            if (transform.position.x == 12 && transform.position.y == 7)
            {
                tileFall.Play("c3-r2");
            }

            if (transform.position.x == 18 && transform.position.y == 7)
            {
                tileFall.Play("c4-r2");
            }

            // Below code animates green tiles in row 3.
            if (transform.position.x == 0 && transform.position.y == 14)
            {
                tileFall.Play("c1-r3");
            }

            if (transform.position.x == 6 && transform.position.y == 14)
            {
                tileFall.Play("c2-r3");
            }

            if (transform.position.x == 12 && transform.position.y == 14)
            {
                tileFall.Play("c3-r3");
            }

            if (transform.position.x == 18 && transform.position.y == 14)
            {
                tileFall.Play("c4-r3");
            }

            // Below code animates green tiles in row 4.
            if (transform.position.x == 0 && transform.position.y == 21)
            {
                tileFall.Play("c1-r4");
            }

            if (transform.position.x == 6 && transform.position.y == 21)
            {
                tileFall.Play("c2-r4");
            }

            if (transform.position.x == 12 && transform.position.y == 21)
            {
                tileFall.Play("c3-r4");
            }

            if (transform.position.x == 18 && transform.position.y == 21)
            {
                tileFall.Play("c4-r4");
            }

            // Below code animates green tiles in row 5.
            if (transform.position.x == 0 && transform.position.y == 28)
            {
                tileFall.Play("c1-r5");
            }

            if (transform.position.x == 6 && transform.position.y == 28)
            {
                tileFall.Play("c2-r5");
            }

            if (transform.position.x == 12 && transform.position.y == 28)
            {
                tileFall.Play("c3-r5");
            }

            if (transform.position.x == 18 && transform.position.y == 28)
            {
                tileFall.Play("c4-r5");
            }
        }
    }
}
