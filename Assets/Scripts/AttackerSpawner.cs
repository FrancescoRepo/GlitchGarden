using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] private bool spawn = true;

    [SerializeField] private Attacker attackerPrefab;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(1f, 5f));
            SpawnAttackers();
        }
    }

    private void SpawnAttackers()
    {
        Attacker newAttacker = Instantiate(attackerPrefab, transform.position, Quaternion.identity);
        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
