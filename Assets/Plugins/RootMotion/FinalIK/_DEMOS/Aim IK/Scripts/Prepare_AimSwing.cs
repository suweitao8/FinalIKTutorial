using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RootMotion.FinalIK;

public class Prepare_AimSwing : MonoBehaviour
{
    public AimIK ik;
    public Vector3 animatedSwingDirection = Vector3.forward;

    private void Start()
    {
        Debug.Log($"当前 transform: {ik.transform.name} => 当前 solver transform: {ik.solver.transform.name}");
    }

    private void LateUpdate()
    {
        ik.solver.axis = ik.solver.transform.InverseTransformVector(ik.transform.rotation * animatedSwingDirection);
    }
}
