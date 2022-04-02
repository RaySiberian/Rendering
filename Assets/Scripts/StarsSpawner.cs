using System.Collections;
using UnityEngine;

public class StarsSpawner : MonoBehaviour
{
    [SerializeField] private float _maxZ; 
    [SerializeField] private float _minZ;
    [SerializeField] private Star _prefab;

    private void Start()
    {
        StartCoroutine(StartSpawn());
    }

    private IEnumerator StartSpawn()
    {
        while (true)
        {
            float zPos = Random.Range(_minZ, _maxZ);
            float randomDelay = Random.Range(3, 7);
            Instantiate(_prefab, new Vector3(-135, 170, zPos), Quaternion.identity);
            yield return new WaitForSeconds(randomDelay);
        }
    }
}
