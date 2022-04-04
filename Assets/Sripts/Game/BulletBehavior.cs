using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
 
    private string _ownerTag;
    [SerializeField]
    private float _damage;
    [SerializeField]
    private float _lifetime;
    private float _currentLifeTime;
    [SerializeField]
    private bool _destroyOnHit;
    private Rigidbody _rigidbody;

    public Rigidbody RigidBody
    {
        get { return _rigidbody; }
    }

    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();

    }

    public string OwnerTag
    {
        get { return _ownerTag; }
        set { _ownerTag = OwnerTag; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(OwnerTag))
            return;

        HealthBehavior otherHealth = other.GetComponent<HealthBehavior>();

        if (!otherHealth)
            return;

        otherHealth.TakeDamage(_damage);

        if (_destroyOnHit)
             Destroy(gameObject);


    }

    private void Update()
    {
        _currentLifeTime += Time.deltaTime;

        if (_currentLifeTime >= _lifetime)
            Destroy(gameObject);
    }
}
