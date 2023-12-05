using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x,0.0f,21.0f),
                                         Mathf.Clamp(target.position.y,0.0f,0.0f),
                                         transform.position.z);
    }
}
