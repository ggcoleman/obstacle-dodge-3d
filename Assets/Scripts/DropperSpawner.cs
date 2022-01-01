using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperSpawner : MonoBehaviour
{
    [SerializeField] bool isLooping = true;

    [SerializeField] float spawnY = 5f;
    [SerializeField] float spawnInterval = 3f;
    [SerializeField] GameObject player;

    [SerializeField] GameObject dropper;

    void Start()
    {
        StartCoroutine(SpawnDropper());
    }

    IEnumerator SpawnDropper()
    {
        do
        {
            Instantiate(dropper, new Vector3(player.transform.position.x, spawnY, player.transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);

        } while (isLooping);
    }
}
