using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Locations[] locations;

    public void GoToLocation(int location)
    {
        int newLocation = Mathf.Clamp(location, 0, locations.Length - 1);
        transform.position = locations[newLocation].position.position;
        transform.rotation = locations[newLocation].position.rotation;
    }
}

[System.Serializable]
public class Locations
{
    [SerializeField] public string name;
    [SerializeField] public Transform position;
}