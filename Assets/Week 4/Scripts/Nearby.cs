using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nearby : MainBehaviourScript
{


    [SerializeField] protected List<EnemyCtrl> enemies;
    [SerializeField] protected EnemyCtrl nearest;



    protected virtual void FixedUpdate()
    {
        this.BaiTap1();
    }

    protected virtual void OnTriggerEnter(Collider collider)
    {

        TargetAble targetAble = collider.GetComponent<TargetAble>();
        if (targetAble == null) return;

        EnemyCtrl enemyCtrl = collider.GetComponentInParent<EnemyCtrl>();
        if(enemyCtrl == null) return;

        this.AddEnemy(enemyCtrl);

        Debug.Log(transform.name + ": " + collider.name, collider.gameObject);
    }



    protected virtual void OnTriggerExit(Collider collider)
    {
        EnemyCtrl enemyCtrl = collider.GetComponentInParent<EnemyCtrl>();
        if(enemyCtrl == null) return;   

        this.RemoveEnemy(enemyCtrl);    
    }
        
    protected void AddEnemy(EnemyCtrl enemy)
    {
        this.enemies.Add(enemy);
    }

    protected void RemoveEnemy(EnemyCtrl enemy)
    {
        this.enemies.Remove(enemy); 
    }

    // Bài Tập 1: Tìm Kẻ Địch Gần Nhất
    void BaiTap1()
    {
        // Tạo danh sách các kẻ địch với tọa độ (x, y, z) trong không gian 3D
        // Vị trí của người chơi được cung cấp
        // Sử dụng công thức khoảng cách Euclid hoặc Vector3.Distance() để tính khoảng cách
        // So sánh khoảng cách và tìm kẻ địch gần nhất
        // Trả về thông tin của kẻ địch gần nhất


        float nearestDistance = Mathf.Infinity;
        float enemyDistance;
        foreach (EnemyCtrl enemy in this.enemies)
        {
            enemyDistance = Vector3.Distance(transform.position, enemy.transform.position);
            if(enemyDistance < nearestDistance)
            {
                nearestDistance = enemyDistance;
                this.nearest = enemy;
            }
        }
    }

    // Bài Tập 2: Tìm Vật Phẩm Gần Nhất
    void BaiTap2()
    {
        // Tạo danh sách các vật phẩm với tọa độ (x, y) trong không gian 2D
        // Vị trí của người chơi được cung cấp
        // Tính khoảng cách từ người chơi đến từng vật phẩm
        // So sánh để tìm vật phẩm gần nhất
        // Trả về thông tin của vật phẩm gần nhất
        float nearestDistance = Mathf.Infinity;
        float enemyDistance;
        foreach (EnemyCtrl enemy in this.enemies)
        {
            enemyDistance = Vector2.Distance(transform.position, enemy.transform.position);
            if (enemyDistance < nearestDistance)
            {
                nearestDistance = enemyDistance;
                this.nearest = enemy;
            }
        }
    }
}
