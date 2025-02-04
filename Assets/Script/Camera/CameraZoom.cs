using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    Camera camera;
    public float zoomValue;
    [SerializeField] Transform spaceship;

    private void Start()
    {
        camera = GetComponent<Camera>();
    }
    void Update()
    {
        camera.orthographicSize = zoomValue - 20;
        Vector3 newpos = spaceship.position;
        newpos.y = transform.position.y;
        
        transform.position = newpos;
        transform.rotation = Quaternion.Euler(90, spaceship.rotation.eulerAngles.y,0);
    }
    public void ZoomInOut(float zoom)
    {
        zoomValue = zoom;
    }
}
