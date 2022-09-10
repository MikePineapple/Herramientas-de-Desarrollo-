using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coconut;
    public GameObject danger;

    public float xBounds, yBounds;

    void Start(){
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject(){
        yield return new WaitForSeconds(Random.Range(1, 2));

        if(Random.value <= .8f)
        {
            Instantiate(coconut,
                new Vector2(xBounds, Random.Range(-yBounds, yBounds)), Quaternion.identity, this.transform);
        }
        else
            Instantiate(danger,
                new Vector2(xBounds, Random.Range(-yBounds, yBounds)), Quaternion.identity, this.transform);

        StartCoroutine(SpawnRandomGameObject());
    }

    private void OnDrawGizmos()
    {

    }
}
