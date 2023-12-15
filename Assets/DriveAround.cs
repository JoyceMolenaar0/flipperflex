using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveAround : MonoBehaviour
{
    [SerializeField] Transform Center;
    [SerializeField] float DistanceFromCenter;
    [SerializeField] float Speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(DistanceFromCenter, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Center.position, Vector3.up, Speed*Time.deltaTime);
        transform.LookAt(Center, Vector3.up);
        transform.Rotate(0, -90, 0);
    }
}
