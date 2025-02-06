using UnityEngine;

public class OrbitCam : MonoBehaviour
{
    [Header("Target Settings")]
    public Transform target;
    public float distance = 5f;
    public Vector3 pivotOffset = Vector3.zero; // Added pivot offset

    [Header("Orbit Animation Settings")]
    public float orbitSpeed = 5f;
    public Vector3 orbitAxis = Vector3.up; // Axis to orbit around

    private float currentOrbitAngle = 0f;

    private void Start()
    {
        if (target == null)
        {
            Debug.LogError("OrbitCamUI: Target Transform is not assigned!");
            return;
        }

        // Initial positioning (optional, can be set in editor)
        UpdateCameraPosition();
    }

    private void Update()
    {
        // Increment the orbit angle based on time and speed
        currentOrbitAngle += orbitSpeed * Time.deltaTime;

        // Keep the angle within 0-360 range (optional, but good for numerical stability)
        if (currentOrbitAngle >= 360f)
        {
            currentOrbitAngle -= 360f;
        }
        else if (currentOrbitAngle < 0f) // Handle negative angles if speed is negative or for other logic
        {
            currentOrbitAngle += 360f;
        }

        // Update the camera position based on the new orbit angle
        UpdateCameraPosition();
    }


    private void UpdateCameraPosition()
    {
        // Calculate the target pivot point
        Vector3 targetPivot = target.position + pivotOffset;

        // Calculate the desired position relative to the target pivot
        Vector3 desiredPositionRelative = Quaternion.AngleAxis(currentOrbitAngle, orbitAxis) * (Vector3.forward * -distance);

        // Add the target pivot to get the final world position
        transform.position = targetPivot + desiredPositionRelative;

        // Make the camera look at the target pivot point
        transform.LookAt(targetPivot);
    }

    // No need for StopOrbitAnimation in this basic logic as the orbit runs continuously in Update
}