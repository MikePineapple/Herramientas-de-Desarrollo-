using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerUpDown : MonoBehaviour
{
    public GameObject coconut;
    public GameObject danger;

    public float xBounds, yBounds;

    void Start()
    {
        StartCoroutine(SpawnRandomGameObjectTop());
    }

    IEnumerator SpawnRandomGameObjectTop()
    {
        yield return new WaitForSeconds(Random.Range(2, 10));

        if (Random.value <= 4)
        {
            Instantiate(coconut,
               new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity, this.transform);
        }
        else
            Instantiate(danger,
                new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity, this.transform);

        StartCoroutine(SpawnRandomGameObjectTop());
    }

    private void OnDrawGizmos()
    {

    }
}
