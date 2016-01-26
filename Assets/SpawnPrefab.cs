using UnityEngine;

/// <summary>
/// Represents the spawning of Sun prefabs.
/// </summary>
public class SpawnPrefab : MonoBehaviour {
    // The Sun prefab.
    public GameObject sunPrefab = null;
    // The distance to move before a prefab is spawned.
    public float distance = 10.0f;

    // The origin of the parent.
    private Vector3 _parentOrigin;

	/// <summary>
    /// Initializes fields.
	/// </summary>
	void Start ()
    {
        // Set the parent origin to the starting origin.
        _parentOrigin = this.transform.localPosition;
	}
	
	/// <summary>
	/// Spawn a new Sun prefab if the parent is moved to a new position
    /// that is far enough from the parent's origin, determined by 'distance'.
	/// </summary>
	void Update ()
    {
        // If the distance of the parent is farther from the set distance
        // from its origin, spawn a new Sun prefab.
        if (Vector3.Distance(_parentOrigin, this.transform.position) > distance)
        {
            GameObject spawnedSolarSystem = GameObject.Instantiate(sunPrefab) as GameObject;
            spawnedSolarSystem.transform.parent = this.transform;
            // Set the parent origin to its current position.
            _parentOrigin = this.transform.localPosition;
        }
	}
}
