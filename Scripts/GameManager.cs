using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public GameObject butterfly;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f);
        InvokeRepeating("CreateButterfly", 3f, 6f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 9f, 0), Quaternion.identity);
    }

    void CreateButterfly()
    {
        Instantiate(butterfly, new Vector3(-12, Random.Range(1f, 6.5f), 0), Quaternion.identity);
    }
}
