using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemyTypes;
    public GameObject[] spawnLocations;
    public float _delay = 2;

    [Space]

    public float _minimumYValue = 1;
    public float _maximumYValue = 5;
    public float _minimumXValue = -1;
    public float _maximumXValue = 1;

    private float _xdirection;
    private float _ydirection;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            var enemySpawned = GameObject.Instantiate(enemyTypes[Random.Range(0, enemyTypes.Length)], spawnLocations[Random.Range(0, spawnLocations.Length)].transform);

            _xdirection = Random.Range(_minimumXValue, _maximumXValue);
            _ydirection = Random.Range(_minimumYValue, _maximumYValue);
            enemySpawned.GetComponent<Rigidbody>().AddForce(new Vector3(_xdirection, _ydirection, 0));
            
            yield return new WaitForSeconds(_delay);
        }

    }

}
