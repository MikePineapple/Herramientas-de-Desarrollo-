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
        yield return new WaitForSeconds(Random.Range(1, 2));

        if (Random.value <= .8f)
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
