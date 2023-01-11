using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraEdgeCollider : MonoBehaviour
{
    private EdgeCollider2D edgeCollider;
    private Camera camera;

    void Awake()
    {
        camera = GetComponent<Camera>();
        edgeCollider = gameObject.AddComponent<EdgeCollider2D>();
        UpdateEdgeCollider();
    }

    private void Update()
    {
        // ToDo Remove if it's too expensive
        UpdateEdgeCollider();
    }

    void UpdateEdgeCollider()
    {
        var bottomLeft = (Vector2)camera.ScreenToWorldPoint(new Vector3(0, 0, camera.nearClipPlane));
        var topLeft = (Vector2)camera.ScreenToWorldPoint(new Vector3(0, camera.pixelHeight, camera.nearClipPlane));
        var topRight = (Vector2)camera.ScreenToWorldPoint(new Vector3(camera.pixelWidth, camera.pixelHeight, camera.nearClipPlane));
        var bottomRight = (Vector2)camera.ScreenToWorldPoint(new Vector3(camera.pixelWidth, 0, camera.nearClipPlane));

        var edgePoints = new[] { bottomLeft, topLeft, topRight, bottomRight };
        edgeCollider.points = edgePoints;
    }
}
