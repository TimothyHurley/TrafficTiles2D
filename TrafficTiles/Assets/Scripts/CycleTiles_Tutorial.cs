using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleTiles_Tutorial : MonoBehaviour
{
    public GameObject[] tiles; // Tile prefabs.
    public GameObject[] columns; // Column game objects.

    public List<GameObject> clones1 = new List<GameObject>(); // List of tiles in column 1.
    public List<GameObject> clones2 = new List<GameObject>(); // List of tiles in column 2.
    public List<GameObject> clones3 = new List<GameObject>(); // List of tiles in column 3.
    public List<GameObject> clones4 = new List<GameObject>(); // List of tiles in column 4.

    // Bools identify the colour of each tile in the bottom row.
    public bool red1 = false;
    public bool amber1 = false;
    public bool green1 = false;

    public bool red2 = false;
    public bool amber2 = false;
    public bool green2 = false;

    public bool red3 = false;
    public bool amber3 = false;
    public bool green3 = false;

    public bool red4 = false;
    public bool amber4 = false;
    public bool green4 = false;

    public bool enableA = false; // Enables 'a' button when true.
    public bool enableD = false; // Enables 'd' button when true.
    public bool enableW = false; // Enables 'w' button when true.
    public bool enableS = false; // Enables 's' button when true.

    public bool enableMoveColumns = false; // Enables MoveColumns function when true.

    public int elementsPerList = 5; // Maximum number of elements in a list.

    public int moveColumnsAmount = 0; // Number of times MoveColumns function has been called.
    
    
    void Start()
    {
        clones1 = GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnTiles_Tutorial>().clones1;
        clones2 = GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnTiles_Tutorial>().clones2;
        clones3 = GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnTiles_Tutorial>().clones3;
        clones4 = GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnTiles_Tutorial>().clones4;
    }

    public void Update()
    {
        if (enableA == true)
        {
            if (Input.GetKeyDown("a"))
            {
                CycleLeftTwoColumns();
            }
        }

        if (enableD == true)
        {
            if (Input.GetKeyDown("d"))
            {
                CycleRightTwoColumns();
            }
        }

        if (enableW == true)
        {
            if (Input.GetKeyDown("w"))
            {
                CycleLeftThreeColumns();
            }

        }

        if (enableS == true)
        {
            if (Input.GetKeyDown("s"))
            {
                CycleRightThreeColumns();
            }
        }
    }

    public void CheckTileColour()
    {
        if (clones1[0].tag == "Red")
        {
            red1 = true;
            amber1 = false;
            green1 = false;
        }

        if (clones1[0].tag == "Amber")
        {
            red1 = false;
            amber1 = true;
            green1 = false;
        }

        if (clones1[0].tag == "Green")
        {
            red1 = false;
            amber1 = false;
            green1 = true;
        }

        if (clones2[0].tag == "Red")
        {
            red2 = true;
            amber2 = false;
            green2 = false;
        }

        if (clones2[0].tag == "Amber")
        {
            red2 = false;
            amber2 = true;
            green2 = false;
        }

        if (clones2[0].tag == "Green")
        {
            red2 = false;
            amber2 = false;
            green2 = true;
        }

        if (clones3[0].tag == "Red")
        {
            red3 = true;
            amber3 = false;
            green3 = false;
        }

        if (clones3[0].tag == "Amber")
        {
            red3 = false;
            amber3 = true;
            green3 = false;
        }

        if (clones3[0].tag == "Green")
        {
            red3 = false;
            amber3 = false;
            green3 = true;
        }

        if (clones4[0].tag == "Red")
        {
            red4 = true;
            amber4 = false;
            green4 = false;
        }

        if (clones4[0].tag == "Amber")
        {
            red4 = false;
            amber4 = true;
            green4 = false;
        }

        if (clones4[0].tag == "Green")
        {
            red4 = false;
            amber4 = false;
            green4 = true;
        }
    }

    public void CycleLeftTwoColumns()
    {
        CheckTileColour();
        
        Vector2 spawnpoint1 = new Vector2(0, 0);

        if (red1)
        {
            GameObject.Destroy(clones1[0]);
            clones1.Add(clones1[0] = Instantiate(tiles[1], spawnpoint1, Quaternion.identity));
        }

        if (amber1)
        {
            GameObject.Destroy(clones1[0]);
            clones1.Add(clones1[0] = Instantiate(tiles[2], spawnpoint1, Quaternion.identity));
        }

        if (green1)
        {
            GameObject.Destroy(clones1[0]);
            clones1.Add(clones1[0] = Instantiate(tiles[0], spawnpoint1, Quaternion.identity));
        }

        Vector2 spawnpoint2 = new Vector2(6, 0);

        if (red2)
        {
            GameObject.Destroy(clones2[0]);
            clones2.Add(clones2[0] = Instantiate(tiles[1], spawnpoint2, Quaternion.identity));
        }

        if (amber2)
        {
            GameObject.Destroy(clones2[0]);
            clones2.Add(clones2[0] = Instantiate(tiles[2], spawnpoint2, Quaternion.identity));
        }

        if (green2)
        {
            GameObject.Destroy(clones2[0]);
            clones2.Add(clones2[0] = Instantiate(tiles[0], spawnpoint2, Quaternion.identity));
        }

        ReduceElementsInList();
        CheckTileColour();

        if (enableMoveColumns && green1 && green2 && green3 && green4)
        {
            moveColumnsAmount++;
            MoveColumns();
        }
    }

    public void CycleLeftThreeColumns()
    {
        CheckTileColour();

        Vector2 spawnpoint1 = new Vector2(0, 0);

        if (red1)
        {
            GameObject.Destroy(clones1[0]);
            clones1.Add(clones1[0] = Instantiate(tiles[1], spawnpoint1, Quaternion.identity));
        }

        if (amber1)
        {
            GameObject.Destroy(clones1[0]);
            clones1.Add(clones1[0] = Instantiate(tiles[2], spawnpoint1, Quaternion.identity));
        }

        if (green1)
        {
            GameObject.Destroy(clones1[0]);
            clones1.Add(clones1[0] = Instantiate(tiles[0], spawnpoint1, Quaternion.identity));
        }

        Vector2 spawnpoint2 = new Vector2(6, 0);

        if (red2)
        {
            GameObject.Destroy(clones2[0]);
            clones2.Add(clones2[0] = Instantiate(tiles[1], spawnpoint2, Quaternion.identity));
        }

        if (amber2)
        {
            GameObject.Destroy(clones2[0]);
            clones2.Add(clones2[0] = Instantiate(tiles[2], spawnpoint2, Quaternion.identity));
        }

        if (green2)
        {
            GameObject.Destroy(clones2[0]);
            clones2.Add(clones2[0] = Instantiate(tiles[0], spawnpoint2, Quaternion.identity));
        }

        Vector2 spawnpoint3 = new Vector2(12, 0);

        if (red3)
        {
            GameObject.Destroy(clones3[0]);
            clones3.Add(clones3[0] = Instantiate(tiles[1], spawnpoint3, Quaternion.identity));
        }

        if (amber3)
        {
            GameObject.Destroy(clones3[0]);
            clones3.Add(clones3[0] = Instantiate(tiles[2], spawnpoint3, Quaternion.identity));
        }

        if (green3)
        {
            GameObject.Destroy(clones3[0]);
            clones3.Add(clones3[0] = Instantiate(tiles[0], spawnpoint3, Quaternion.identity));
        }

        ReduceElementsInList();
        CheckTileColour();

        if (enableMoveColumns && green1 && green2 && green3 && green4)
        {
            moveColumnsAmount++;
            MoveColumns();
        }
    }

    public void CycleRightTwoColumns()
    {
        CheckTileColour();

        Vector2 spawnpoint3 = new Vector2(12, 0);

        if (red3)
        {
            GameObject.Destroy(clones3[0]);
            clones3.Add(clones3[0] = Instantiate(tiles[1], spawnpoint3, Quaternion.identity));
        }

        if (amber3)
        {
            GameObject.Destroy(clones3[0]);
            clones3.Add(clones3[0] = Instantiate(tiles[2], spawnpoint3, Quaternion.identity));
        }

        if (green3)
        {
            GameObject.Destroy(clones3[0]);
            clones3.Add(clones3[0] = Instantiate(tiles[0], spawnpoint3, Quaternion.identity));
        }

        Vector2 spawnpoint4 = new Vector2(18, 0);

        if (red4)
        {
            GameObject.Destroy(clones4[0]);
            clones4.Add(clones4[0] = Instantiate(tiles[1], spawnpoint4, Quaternion.identity));
        }

        if (amber4)
        {
            GameObject.Destroy(clones4[0]);
            clones4.Add(clones4[0] = Instantiate(tiles[2], spawnpoint4, Quaternion.identity));
        }

        if (green4)
        {
            GameObject.Destroy(clones4[0]);
            clones4.Add(clones4[0] = Instantiate(tiles[0], spawnpoint4, Quaternion.identity));
        }

        ReduceElementsInList();
        CheckTileColour();

        if (enableMoveColumns && green1 && green2 && green3 && green4)
        {
            moveColumnsAmount++;
            MoveColumns();
        }
    }

    public void CycleRightThreeColumns()
    {
        CheckTileColour();

        Vector2 spawnpoint2 = new Vector2(6, 0);

        if (red2)
        {
            GameObject.Destroy(clones2[0]);
            clones2.Add(clones2[0] = Instantiate(tiles[1], spawnpoint2, Quaternion.identity));
        }

        if (amber2)
        {
            GameObject.Destroy(clones2[0]);
            clones2.Add(clones2[0] = Instantiate(tiles[2], spawnpoint2, Quaternion.identity));
        }

        if (green2)
        {
            GameObject.Destroy(clones2[0]);
            clones2.Add(clones2[0] = Instantiate(tiles[0], spawnpoint2, Quaternion.identity));
        }
        
        Vector2 spawnpoint3 = new Vector2(12, 0);

        if (red3)
        {
            GameObject.Destroy(clones3[0]);
            clones3.Add(clones3[0] = Instantiate(tiles[1], spawnpoint3, Quaternion.identity));
        }

        if (amber3)
        {
            GameObject.Destroy(clones3[0]);
            clones3.Add(clones3[0] = Instantiate(tiles[2], spawnpoint3, Quaternion.identity));
        }

        if (green3)
        {
            GameObject.Destroy(clones3[0]);
            clones3.Add(clones3[0] = Instantiate(tiles[0], spawnpoint3, Quaternion.identity));
        }

        Vector2 spawnpoint4 = new Vector2(18, 0);

        if (red4)
        {
            GameObject.Destroy(clones4[0]);
            clones4.Add(clones4[0] = Instantiate(tiles[1], spawnpoint4, Quaternion.identity));
        }

        if (amber4)
        {
            GameObject.Destroy(clones4[0]);
            clones4.Add(clones4[0] = Instantiate(tiles[2], spawnpoint4, Quaternion.identity));
        }

        if (green4)
        {
            GameObject.Destroy(clones4[0]);
            clones4.Add(clones4[0] = Instantiate(tiles[0], spawnpoint4, Quaternion.identity));
        }

        ReduceElementsInList();
        CheckTileColour();

        if (enableMoveColumns && green1 && green2 && green3 && green4)
        {
            moveColumnsAmount++;
            MoveColumns();
        }
    }

    public void MoveColumns()
    {
        if (moveColumnsAmount == 1)
        {
            enableA = false;
            enableD = false;
            enableW = false;
            enableS = false;
            enableMoveColumns = false;
            
            GameObject.FindGameObjectWithTag("Dialogue").GetComponent<Dialogue>().NextLine();
            GameObject.FindGameObjectWithTag("Dialogue").GetComponent<Dialogue>().arrowRow1.gameObject.SetActive(true);
            GameObject.FindGameObjectWithTag("Dialogue").GetComponent<Dialogue>().arrowRow2.gameObject.SetActive(true);
        }

        green1 = false;
        green2 = false;
        green3 = false;
        green4 = false;

        for (int i = 0; i < elementsPerList; i++)
        {
            clones1[i].GetComponent<MoveTiles>().MoveThisGameObject();
            clones2[i].GetComponent<MoveTiles>().MoveThisGameObject();
            clones3[i].GetComponent<MoveTiles>().MoveThisGameObject();
            clones4[i].GetComponent<MoveTiles>().MoveThisGameObject();
        }

        GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer_Tutorial>().IncreaseTimerValue();

        GameObject.FindGameObjectWithTag("Score").GetComponent<PlayerScore>().IncreasePlayerScore();
        
        clones1.RemoveAt(0);
        clones2.RemoveAt(0);
        clones3.RemoveAt(0);
        clones4.RemoveAt(0);
        
        ReduceElementsInList();

        GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnTiles_Tutorial>().yRow = 28;
        GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnTiles_Tutorial>().tilesToSpawn = 1;
        GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnTiles_Tutorial>().SpawnColumn1();
        GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnTiles_Tutorial>().SpawnColumn2();
        GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnTiles_Tutorial>().SpawnColumn3();
        GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnTiles_Tutorial>().SpawnColumn4();
    }

    public void ReduceElementsInList()
    {
        if (clones1.Count > elementsPerList)
        {
            clones1.RemoveAt(elementsPerList);
        }

        if (clones2.Count > elementsPerList)
        {
            clones2.RemoveAt(elementsPerList);
        }

        if (clones3.Count > elementsPerList)
        {
            clones3.RemoveAt(elementsPerList);
        }

        if (clones4.Count > elementsPerList)
        {
            clones4.RemoveAt(elementsPerList);
        }
    }
}
