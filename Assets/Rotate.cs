using UnityEngine;

/// <summary>
/// Represents a rotating Sun and Earth.
/// </summary>
public class Rotate : MonoBehaviour {
    // The Earth object.
    public GameObject earth = null;
    // The rotation angle.
    public float rotationAngle = 2.0f;

    /// <summary>
    /// Use this for initialization.
    /// </summary>
	void Start ()
    {
        // Nothing here.
	}
	
	/// <summary>
    /// Rotates both the Sun and Earth.
	/// </summary>
	void Update ()
    {
        this.transform.Rotate(0, 0, rotationAngle);
        earth.transform.Rotate(0, 0, rotationAngle);
	}
}
