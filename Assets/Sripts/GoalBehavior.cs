using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour
{
    private int _enemyCount = 0;
    private float _health = 10;

    public int EnemyCount
    {
        get { return _enemyCount; }
        set { _enemyCount = EnemyCount; }
    }

    private void Update()
    {
        if (_enemyCount > _health)
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            if (renderer)
            {
                renderer.material;
            }
        }
    }
}
