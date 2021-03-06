using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehavior : MovementBehavior
{
    [SerializeField]
    private GameObject _target;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _damage;
    public GameObject Target
    {
        get { return _target; }
        set { _target = Target; }
    }

    public float Speed
    {
        get { return _speed; }
        set { _speed = Speed; }
    }

    // Update is called once per frame
    public override void Update()
    {
        Vector3 direction = _target.transform.position - transform.position;
        Velocity = direction.normalized * Speed;

        base.Update();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _target)
        {
            //Increment the enemy count if the target was a goal
            GoalBehavior goalHealth = other.GetComponent<GoalBehavior>();
            if (goalHealth)
            {
                goalHealth.TakeDamage(_damage);
                Destroy(gameObject);
            }
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
