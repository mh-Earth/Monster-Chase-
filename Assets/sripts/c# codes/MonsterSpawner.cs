using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject[] MonsterRefrenes;

    private GameObject spawnerMonster;
    [SerializeField]
    private Transform leftPos, rightPos;

    private int randonIndex;
    private int randomSide;

    public int MonsterSpawnNumber = 0;
    void Start()
    {
        StartCoroutine(spawnMonsters());
    }

    IEnumerator spawnMonsters()
    {
        while (true)
        {

            yield return new WaitForSeconds(Random.Range(1, 8));

            randonIndex = Random.Range(0, MonsterRefrenes.Length);
            randomSide = Random.Range(0, 2);

            spawnerMonster = Instantiate(MonsterRefrenes[randonIndex]);
            MonsterSpawnNumber += 1;

            if (randomSide == 0)
            {
                spawnerMonster.transform.position = leftPos.position;
                spawnerMonster.GetComponent<monsterMovment>().speed = Random.Range(5, 10);
                // spawnerMonster.transform.localScale = new Vector3(-1f,1f,1f);


            }

            else
            {

                spawnerMonster.transform.position = rightPos.position;
                spawnerMonster.GetComponent<monsterMovment>().speed = -Random.Range(5, 7);
                spawnerMonster.transform.localScale = new Vector3(-1f, 1f, 1f);


            }


        }
    }


}
