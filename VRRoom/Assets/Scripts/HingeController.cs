using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class HingeController : MonoBehaviour
{
    private HingeJoint hinge;

    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
        LockHinge();
    }

    public void LockHinge()
    {
        hinge.useMotor = false;
    }

    public void UnlockHinge()
    {
        hinge.useMotor = true;
    }
}
