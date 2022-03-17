using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrpRecognize : MonoBehaviour
{

    public LayerMask sellLayer =3;

    public Vector2 size;

    public bool hit =false;

    private void Start()
    {
        gameObject.layer = 0;
    }
    private void Update()
    {
        hit = Physics2D.OverlapCircle(transform.position,0.3f , sellLayer);


    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 0.3f);

    }

}
