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
        yield return new WaitForSeconds(Random.Range(2, 10));

        if(Random.value <= 4){
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
