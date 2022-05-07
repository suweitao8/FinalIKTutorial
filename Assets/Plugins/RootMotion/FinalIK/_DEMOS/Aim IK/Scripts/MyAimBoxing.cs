using RootMotion.FinalIK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAimBoxing : MonoBehaviour
{
    public Transform normalTarget;
    public Transform boxTarget;

    public Transform aimTransform;
    public AimIK aimIK;

    private void LateUpdate()
    {
        aimTransform.LookAt(normalTarget);
        aimIK.solver.IKPosition = boxTarget.position;
    }
}
