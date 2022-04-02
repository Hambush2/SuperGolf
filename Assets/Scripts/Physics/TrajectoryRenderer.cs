using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class TrajectoryRenderer : MonoBehaviour
{
    private LineRenderer _lineRenderer;

    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    public void ShowTrajectory(Vector3 origin, Vector3 target, Vector3 speed)
    {
        Vector3[] points = new Vector3[20];
        _lineRenderer.positionCount = points.Length;

        Vector3 launchPoint = origin;
        Vector3 targetPoint = target;

        for (int i = 0; i < points.Length; i++)
        {
            float time = i * 0.1f;

            points[i] = origin + speed * time + Physics.gravity * time * time / 2f;

            if(points[i].y < 0)
            {
                _lineRenderer.positionCount = i + 1;
                break;
            }    
        }

        _lineRenderer.SetPositions(points);
    }
}
