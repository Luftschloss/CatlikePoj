using UnityEngine;


[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class Triangle : MonoBehaviour
{

    private void Start()
    {
        Generate();
    }

    void Generate()
    {
        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[3];
        Vector2[] uvs = new Vector2[3];
        int[] triangles = new int[3];
        uvs[0] = new Vector2(1, 1);
        uvs[1] = new Vector2(1, 0);
        uvs[2] = new Vector2(0, 0);

        for (int i = 0; i < 3; i++)
        {
            float angle = (90 - 120 * i) * Mathf.Deg2Rad;
            vertices[i] = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * 3;
            triangles[i] = i;
        }
        
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;

        GetComponent<MeshFilter>().mesh = mesh;
    }
}
