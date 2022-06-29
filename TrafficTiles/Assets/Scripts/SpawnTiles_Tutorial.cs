using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTiles_Tutorial : MonoBehaviour
{
    public GameObject[] tiles; // Tile prefabs.
    
    public List<GameObject> clones1 = new List<GameObject>(); // List of tiles in column 1.
    public List<GameObject> clones2 = new List<GameObject>(); // List of tiles in column 2.
    public List<GameObject> clones3 = new List<GameObject>(); // List of tiles in column 3.
    public List<GameObject> clones4 = new List<GameObject>(); // List of tiles in column 4.

    public float yRow = 0; // Y value of a row of tiles.
    
    public int tileVariant; // 0 spawns red, 1 spawns amber, 2 spawns green.
    public int tilesToSpawn = 5; // Number of tiles to spawn in each column.
    public int yDistance = 7; // Distance between each row of tiles.

    public int notGreenCount1 = 6; // Number of red and amber tiles in column 1. Value starts at 6.
    public int notGreenCount2 = 7; // Number of red and amber tiles in column 2. Value starts at 7.
    public int notGreenCount3 = 6; // Number of red and amber tiles in column 3. Value starts at 6.
    public int notGreenCount4 = 7; // Number of red and amber tiles in column 4. Value starts at 7.


    void Awake()
    {
        SpawnColumn1();
        SpawnColumn2();
        SpawnColumn3();
        SpawnColumn4();
    }

    public void SpawnColumn1()
    {
        for (int i = 0; i < tilesToSpawn; i++)
        {
            tileVariant = Random.Range(0, 3);
            Vector2 spawnpoint = new Vector2(0, i * yDistance + yRow);

            if (tileVariant == 0)
            {
                clones1.Add(Instantiate(tiles[0], spawnpoint, Quaternion.identity));
                notGreenCount1++;
            }

            if (tileVariant == 1)
            {
                clones1.Add(Instantiate(tiles[1], spawnpoint, Quaternion.identity));
                notGreenCount1++;
            }

            if (tileVariant == 2)
            {
                if (notGreenCount1 >= 7)
                {
                    clones1.Add(Instantiate(tiles[2], spawnpoint, Quaternion.identity));
                    notGreenCount1 = 0;
                }

                else
                {
                    tileVariant = Random.Range(0, 2);

                    if (tileVariant == 0)
                    {
                        clones1.Add(Instantiate(tiles[0], spawnpoint, Quaternion.identity));
                        notGreenCount1++;
                    }

                    if (tileVariant == 1)
                    {
                        clones1.Add(Instantiate(tiles[1], spawnpoint, Quaternion.identity));
                        notGreenCount1++;
                    }
                }
            }
        }
    }

    public void SpawnColumn2()
    {
        for (int i = 0; i < tilesToSpawn; i++)
        {
            tileVariant = Random.Range(0, 3);
            Vector2 spawnpoint = new Vector2(6, i * yDistance + yRow);

            if (tileVariant == 0)
            {
                clones2.Add(Instantiate(tiles[0], spawnpoint, Quaternion.identity));
                notGreenCount2++;
            }

            if (tileVariant == 1)
            {
                clones2.Add(Instantiate(tiles[1], spawnpoint, Quaternion.identity));
                notGreenCount2++;
            }

            if (tileVariant == 2)
            {
                if (notGreenCount2 >= 7)
                {
                    clones2.Add(Instantiate(tiles[2], spawnpoint, Quaternion.identity));
                    notGreenCount2 = 0;
                }

                else
                {
                    tileVariant = Random.Range(0, 2);

                    if (tileVariant == 0)
                    {
                        clones2.Add(Instantiate(tiles[0], spawnpoint, Quaternion.identity));
                        notGreenCount2++;
                    }

                    if (tileVariant == 1)
                    {
                        clones2.Add(Instantiate(tiles[1], spawnpoint, Quaternion.identity));
                        notGreenCount2++;
                    }
                }
            }
        }
    }

    public void SpawnColumn3()
    {
        for (int i = 0; i < tilesToSpawn; i++)
        {
            tileVariant = Random.Range(0, 3);
            Vector2 spawnpoint = new Vector2(12, i * yDistance + yRow);

            if (tileVariant == 0)
            {
                clones3.Add(Instantiate(tiles[0], spawnpoint, Quaternion.identity));
                notGreenCount3++;
            }

            if (tileVariant == 1)
            {
                clones3.Add(Instantiate(tiles[1], spawnpoint, Quaternion.identity));
                notGreenCount3++;
            }

            if (tileVariant == 2)
            {
                if (notGreenCount3 >= 7)
                {
                    clones3.Add(Instantiate(tiles[2], spawnpoint, Quaternion.identity));
                    notGreenCount3 = 0;
                }

                else
                {
                    tileVariant = Random.Range(0, 2);

                    if (tileVariant == 0)
                    {
                        clones3.Add(Instantiate(tiles[0], spawnpoint, Quaternion.identity));
                        notGreenCount3++;
                    }

                    if (tileVariant == 1)
                    {
                        clones3.Add(Instantiate(tiles[1], spawnpoint, Quaternion.identity));
                        notGreenCount3++;
                    }
                }
            }
        }
    }

    public void SpawnColumn4()
    {
        for (int i = 0; i < tilesToSpawn; i++)
        {
            tileVariant = Random.Range(0, 3);
            Vector2 spawnpoint = new Vector2(18, i * yDistance + yRow);

            if (tileVariant == 0)
            {
                clones4.Add(Instantiate(tiles[0], spawnpoint, Quaternion.identity));
                notGreenCount4++;
            }

            if (tileVariant == 1)
            {
                clones4.Add(Instantiate(tiles[1], spawnpoint, Quaternion.identity));
                notGreenCount4++;
            }

            if (tileVariant == 2)
            {
                if (notGreenCount4 >= 7)
                {
                    clones4.Add(Instantiate(tiles[2], spawnpoint, Quaternion.identity));
                    notGreenCount4 = 0;
                }

                else
                {
                    tileVariant = Random.Range(0, 2);

                    if (tileVariant == 0)
                    {
                        clones4.Add(Instantiate(tiles[0], spawnpoint, Quaternion.identity));
                        notGreenCount4++;
                    }

                    if (tileVariant == 1)
                    {
                        clones4.Add(Instantiate(tiles[1], spawnpoint, Quaternion.identity));
                        notGreenCount4++;
                    }
                }
            }
        }
    }
}
