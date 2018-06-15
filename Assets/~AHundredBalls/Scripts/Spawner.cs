using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AHundredBalls
{
    public class Spawner : MonoBehaviour
    {

        public GameObject prefab;
        public float spawnDelay;

        // Use this for initialization
        void Start()
        {

        }
        IEnumerator Spawn()
        {
            yield return new WaitForSeconds(spawnDelay);

            Instantiate(prefab, transform.position, transform.rotation);

            StartCoroutine(Spawn());

        }
    }
}