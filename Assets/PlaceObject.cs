using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceObject : MonoBehaviour
{
    public GameObject mazePrefab; // Assign the 3D maze prefab in Unity
    private ARRaycastManager raycastManager;
    private GameObject spawnedMaze;

    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                List<ARRaycastHit> hits = new List<ARRaycastHit>();
                if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
                {
                    Pose hitPose = hits[0].pose;
                    
                    if (spawnedMaze == null)
                    {
                        spawnedMaze = Instantiate(mazePrefab, hitPose.position, hitPose.rotation);
                    }
                }
            }
        }
    }
}
