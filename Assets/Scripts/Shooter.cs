using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Projectile projectile;
    [SerializeField] private GameObject gun;
    private AttackerSpawner laneSpawner;
    private Animator animator;

    void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetBool("IsAttacking", IsAttackerInLane());
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach (var attackerSpawner in spawners)
        {
            bool isCloseEnough = (Mathf.Abs(attackerSpawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (isCloseEnough)
            {
                laneSpawner = attackerSpawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        return laneSpawner.transform.childCount > 0;
    }
}
