using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour
{
    public Rigidbody shell;
    public Transform fireTransform;

    public float minLaunchForce=15.0f;
    public float maxLaunchForce=30.0f;
    public float chargeTime=0.75f;//time required to from min to max launch force

    private float currentLaunchForce;
    private float chargeSpeed;
    public bool fired;

    private void OnEnable()
    {
        currentLaunchForce = minLaunchForce;
    }
    private void Start()
    {
        chargeSpeed = (maxLaunchForce - minLaunchForce) / chargeTime;
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        Rigidbody newShell = Instantiate(shell,fireTransform.position,fireTransform.rotation) as Rigidbody;
        newShell.velocity = currentLaunchForce * fireTransform.forward;
    }
}
