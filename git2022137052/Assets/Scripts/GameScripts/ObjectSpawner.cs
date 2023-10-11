using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnDelay = 5f;

    private void Start()
    {
        // ���� �ð��� ���� �Ŀ� SpawnObject �Լ��� ȣ���մϴ�.
        StartCoroutine(SpawnObjectAfterDelay());
    }

    private IEnumerator SpawnObjectAfterDelay()
    {
        // spawnDelay �� ���
        yield return new WaitForSeconds(spawnDelay);

        // objectToSpawn �������� �����մϴ�.
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}