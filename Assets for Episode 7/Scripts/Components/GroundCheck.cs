using UnityEngine;

[ExecuteInEditMode]
public class GroundCheck : MonoBehaviour
{

    public float distanceThreashold = .15f;

    public bool isGrounded = true;

    public event System.Action Grounded;

    const float OrginOffset = .001f;
    Vector3 RaycastOrigin => transform.position + Vector3.up * OrginOffset;
    float RaycastDistance => distanceThreashold + OrginOffset;

    void LateUpdate()
    {
        bool isGroundedNow = Physics.Raycast(RaycastOrigin, Vector3.down, distanceThreashold * 2);

        if (isGroundedNow && !isGrounded)
        {
            Grounded?.Invoke();
        }

        isGrounded = isGroundedNow;
    }

    void OnDrawGizmosSelected()
    {
        Debug.DrawLine(RaycastOrigin, RaycastOrigin + Vector3.down * RaycastDistance, isGrounded ? Color.white : Color.red);
    }
}
