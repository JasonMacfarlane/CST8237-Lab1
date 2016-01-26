using UnityEngine;

/// <summary>
/// Represents the Earth moving closer and farther away from the Sun
/// as it rotates.
/// </summary>
public class TowardsAway : MonoBehaviour {
    // The closest distance to the Sun.
    public float closestDistance = 7.0f;
    // The farthest distance from the Sun.
    public float farthestDistance = 15.0f;
    // The speed at which the Earth moves to and from the Sun.
    public float moveSpeed = 0.5f;
    
    // Should the Earth move closer to the Sun?
    private bool _shouldMoveCloser = false;

	/// <summary>
    /// Use this for initialization.
	/// </summary>
	void Start ()
    {
	    // Nothing here.
	}
	
	/// <summary>
    /// Moves the Earth closer and farther from the sun
    /// as it rotates around it.
	/// </summary>
	void Update ()
    {
        Vector3 localPosition = this.transform.localPosition;

        // Change the Earth's position depending on if
        // if should be moving closer or farther away
        // from the Sun.
        if (_shouldMoveCloser)
        {
            // Decrease the value of 'x' relative to the Sun.
            localPosition.x -= moveSpeed;
            // If the Earth's position is at the closest distance
            // allowed to the Sun, set _shouldMoveCloser to false,
            // to make sure the Earth starts moving farther away.
            if (localPosition.x <= closestDistance)
                _shouldMoveCloser = false;
        }
        
        else
        {
            // Increase the value of 'x' relative to the Sun.
            localPosition.x += moveSpeed;
            // If the Earth's position is at the farthest distance
            // allowed from the Sun, set _shouldMoveCloser to true,
            // to make the sure Earth starts moving closer.
            if (localPosition.x >= farthestDistance)
                _shouldMoveCloser = true;
        }

        // Move the Earth.
        this.transform.localPosition = localPosition;
    }
}
