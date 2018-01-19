using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Geometry;

public class ShapeCreator : MonoBehaviour
{
    public MeshFilter meshFilter;

    [HideInInspector]
    public List<Shape> shapes = new List<Shape>();

    [HideInInspector]
    public bool showShapeList;

    public float handleRadius = .5f;

    public void UpdateMeshDisplay()
    {
        CompositeShape comShape = new CompositeShape(shapes);
        meshFilter.mesh = comShape.GetMesh();
    }
}
