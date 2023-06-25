using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymaker : MonoBehaviour
{
    [SerializeField] private GameObject enemyprefab;
    [SerializeField] private float makeTime;
    private float waitTime;
    [SerializeField] private float enemyZ;
    [SerializeField] private float enemyX;
    private float rankX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(waitTime < makeTime)
        {
            waitTime = waitTime + Time.deltaTime;
        }

        else
        {
            rankX = Random.Range(enemyX * -1, enemyX);
            Instantiate(enemyprefab, new Vector3(rankX, 0, enemyZ), enemyprefab.transform.rotation);

            waitTime = 0;
        }
        
    }
}
