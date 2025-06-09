using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class SimpleFrogMesh : MonoBehaviour
{
    void Start()
    {
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        Vector3[] vertices = new Vector3[]
        {
            // Base du corps (rectangle)
            new Vector3(-0.5f, 0, -0.3f),
            new Vector3(0.5f, 0, -0.3f),
            new Vector3(-0.5f, 0, 0.3f),
            new Vector3(0.5f, 0, 0.3f),

            // Haut du corps (plus haut)
            new Vector3(-0.4f, 0.3f, -0.2f),
            new Vector3(0.4f, 0.3f, -0.2f),
            new Vector3(-0.4f, 0.3f, 0.2f),
            new Vector3(0.4f, 0.3f, 0.2f),

            // Tête
            new Vector3(-0.2f, 0.5f, 0.35f),
            new Vector3(0.2f, 0.5f, 0.35f),
        };

        int[] triangles = new int[]
        {
            // Bas du corps
            0,2,1,
            2,3,1,

            // Côtés bas->haut
            0,4,2,
            2,4,6,
            1,3,5,
            3,7,5,
            4,5,6,
            5,7,6,

            // Haut du corps
            6,7,8,
            7,9,8,
        };

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();

        // Material vert grenouille simple
        GetComponent<MeshRenderer>().material = new Material(Shader.Find("Standard"));
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
