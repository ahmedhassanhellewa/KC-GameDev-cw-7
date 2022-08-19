using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    public Transform spawn;
    public Transform spawnright;
    public Transform spawnleft;

    public GameObject enemy;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating ("spawnEnemy",0f,delay );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnEnemy()
    {
        int randNum = Random.Range(1, 4);
        if (randNum ==1)
        {
            Instantiate(enemy, spawnleft);

        }
         else if (randNum ==2)
        {
            Instantiate(enemy, spawn);

        }
         else
        {
            Instantiate(enemy, spawnright);

        }
        
    }
}
