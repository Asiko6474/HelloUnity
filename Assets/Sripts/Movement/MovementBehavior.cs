using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementBehavior : MonoBehaviour
{
    [SerializeField]
    private Vector3 _velocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public Vector3 Velocity
    {
        get {return _velocity;}
        set { _velocity = value; }
    }



    // Update is called once per frame
    public virtual void Update()
    {
        transform.position += Velocity * Time.deltaTime;
    }
}
