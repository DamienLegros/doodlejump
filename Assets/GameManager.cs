using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject doodler;
    public GameObject plateformPrefab;
    public GameObject plateformMovePrefab;
    public GameObject plateformBrokePrefab;
    public GameObject blackHolePrefab;
    public GameObject jumperPrefab;
    public GameObject capPrefab;
    public GameObject jetpackPrefab;
    public GameObject redMonsterPrefab;
    public GameObject blueMonsterPrefab;
    public GameObject flyMonsterPrefab;

    private Vector3 spawnPosition;

    private int generation = 300;

    private int nextPlateform1, nextPlateform2, nextBlackHole, nextJumper;
    private int nextCap, nextJetpack, nextMonster1, nextMonster2;
    private int nextMonster3, only1broke = 1, only1black = 1, only1monster = 1;

    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = new Vector3();
        Generate();

    }

    void Generate()
    {
        for (int i = 0; i < generation; i++)
        {
            nextPlateform1 = Random.Range(1, 8);
            nextPlateform2 = Random.Range(1, 10);
            nextJumper = Random.Range(1, 20);
            nextCap = Random.Range(1, 25);
            nextJetpack = Random.Range(1, 30);
            nextBlackHole = Random.Range(1, 30);
            nextMonster1 = Random.Range(1, 20);
            nextMonster2 = Random.Range(1, 20);
            nextMonster3 = Random.Range(1, 20);

            if (nextPlateform1 == 1 && only1broke == 0)
            {
                spawnPosition.y += Random.Range(.5f, 2f);
                spawnPosition.x = Random.Range(-2f, 2f);
                Instantiate(plateformBrokePrefab, spawnPosition, Quaternion.identity);
                only1broke = 1;
            }
            else
            {
                only1broke = 0;
                if (nextPlateform2 == 1)
                {
                    if (nextBlackHole == 1 && only1black == 0)
                    {
                        spawnPosition.y += 0.25f;
                        spawnPosition.y += Random.Range(.5f, 2f);
                        spawnPosition.x = Random.Range(-2f, 2f);
                        Instantiate(blackHolePrefab, spawnPosition, Quaternion.identity);
                        spawnPosition.y += 0.25f;
                        only1black = 1;
                    }

                    else if (nextMonster1 == 1 && only1monster == 0)
                    {
                        spawnPosition.y += 0.25f;
                        spawnPosition.y += Random.Range(.5f, 2f);
                        spawnPosition.x = Random.Range(-2f, 2f);
                        Instantiate(redMonsterPrefab, spawnPosition, Quaternion.identity);
                        spawnPosition.y += 0.25f;
                        only1monster = 1;
                    }
                    else if (nextMonster2 == 1 && only1monster == 0)
                    {
                        spawnPosition.y += 0.25f;
                        spawnPosition.y += Random.Range(.5f, 2f);
                        spawnPosition.x = Random.Range(-2f, 2f);
                        Instantiate(blueMonsterPrefab, spawnPosition, Quaternion.identity);
                        spawnPosition.y += 0.25f;
                        only1monster = 1;
                    }
                    else if (nextMonster3 == 1 && only1monster == 0)
                    {
                        spawnPosition.y += 0.25f;
                        spawnPosition.y += Random.Range(.5f, 2f);
                        spawnPosition.x = Random.Range(-2f, 2f);
                        Instantiate(flyMonsterPrefab, spawnPosition, Quaternion.identity);
                        spawnPosition.y += 0.25f;
                        only1monster = 1;
                    }
                    else
                    {
                        spawnPosition.y += Random.Range(.5f, 2f);
                        spawnPosition.x = Random.Range(-2f, 2f);
                        Instantiate(plateformMovePrefab, spawnPosition, Quaternion.identity);
                    }
                }
                else
                {
                    only1black = 0;
                    only1monster = 0;
                    spawnPosition.y += Random.Range(.5f, 2f);
                    spawnPosition.x = Random.Range(-2f, 2f);
                    Instantiate(plateformPrefab, spawnPosition, Quaternion.identity);
                    if (nextJumper == 1)
                    {
                        spawnPosition.y += 0.245f;
                        spawnPosition.x = spawnPosition.x + Random.Range(-0.4f, 0.4f);
                        Instantiate(jumperPrefab, spawnPosition, Quaternion.identity);
                    }
                    else if (nextCap == 1)
                    {
                        spawnPosition.y += 0.32f;
                        spawnPosition.x = spawnPosition.x + Random.Range(-0.4f, 0.4f);
                        Instantiate(capPrefab, spawnPosition, Quaternion.identity);
                    }
                    else if (nextJetpack == 1)
                    {
                        spawnPosition.y += 0.505f;
                        spawnPosition.x = spawnPosition.x + Random.Range(-0.4f, 0.4f);
                        Instantiate(jetpackPrefab, spawnPosition, Quaternion.identity);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (doodler.transform.position.y > spawnPosition.y - 50)
            Generate();
    }
}
