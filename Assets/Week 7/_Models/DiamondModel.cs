using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[RequireComponent(typeof(BoxCollider))]

public class DiamondModel : MainBehaviourScript
{
     private Mesh mesh; 
    private BoxCollider collider; 


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadMeshDiamond();
    }

    protected virtual void LoadMeshDiamond()
    {
        if (this.mesh != null) return;

        // Khởi tạo Mesh mới
        this.mesh = new Mesh();
        this.mesh.name = "DiamondMesh";

        // Lấy MeshFilter và gán Mesh
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        if (meshFilter == null)
        {
            Debug.LogError("MeshFilter không tồn tại trên GameObject này!");
            return;
        }
        meshFilter.mesh = this.mesh;

        // Thiết lập Mesh
        this.SetupMesh();
        this.AddBoxCollider();
    }

    protected virtual void SetupMesh()
    {
        // Định nghĩa các đỉnh (vertices)
        Vector3[] vertices = new Vector3[]
        {
            // Đỉnh trên
            new Vector3(0, 1, 0), // Đỉnh 0
            // Đỉnh giữa (hình vuông)
            new Vector3(-0.5f, 0, -0.5f), // Đỉnh 1
            new Vector3(0.5f, 0, -0.5f),  // Đỉnh 2
            new Vector3(0.5f, 0, 0.5f),   // Đỉnh 3
            new Vector3(-0.5f, 0, 0.5f),  // Đỉnh 4
            // Đỉnh dưới
            new Vector3(0, -1, 0)         // Đỉnh 5
        };

        // Định nghĩa các tam giác (triangles)
        int[] triangles = new int[]
        {
            // Tam giác phía trên
            0, 1, 2,
            0, 2, 3,
            0, 3, 4,
            0, 4, 1,

            // Tam giác phía dưới
            5, 2, 1,
            5, 3, 2,
            5, 4, 3,
            5, 1, 4
        };

        // Định nghĩa UV (nếu cần texture)
        Vector2[] uv = new Vector2[]
        {
            new Vector2(0.5f, 1), // Đỉnh trên
            new Vector2(0, 0.5f), // Góc trái dưới
            new Vector2(1, 0.5f), // Góc phải dưới
            new Vector2(1, 0.5f), // Góc phải trên
            new Vector2(0, 0.5f), // Góc trái trên
            new Vector2(0.5f, 0)  // Đỉnh dưới
        };

        // Gán dữ liệu vào Mesh
        this.mesh.vertices = vertices;
        this.mesh.triangles = triangles;
        this.mesh.uv = uv;

        // Tính toán lại các thuộc tính (bắt buộc)
        this.mesh.RecalculateNormals();
        this.mesh.RecalculateBounds();

        // Gán Mesh cho MeshFilter
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = this.mesh;

        // Thêm vật liệu mặc định cho MeshRenderer
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material = new Material(Shader.Find("Standard"));
    }




    protected virtual void AddBoxCollider()
    {

        if (this.collider != null) return;
        this.collider = GetComponent<BoxCollider>();
       

        
        this.collider.center = Vector3.zero;
        this.collider.size = new Vector3(1f, 2f, 1f);
    }
}
