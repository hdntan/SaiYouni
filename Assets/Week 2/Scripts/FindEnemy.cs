using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{

    List<EnemyAbstract> enemies = new();
    List<EnemyAbstract> enemiesSort = new();

    EnemyAbstract minEnemy;
    EnemyAbstract maxEnemy;
    private void Start()
    {
        Debug.Log("=============EnemyManager Start: ");
        this.LoadEnemies();
        this.ShowEnemies();

        this.enemiesSort = new(this.enemies);

        Debug.Log("=============================================");
        Debug.Log("=============EnemyFindEnemyWithSmallestHealth: ");

        this.minEnemy = this.EnemyFindEnemyWithSmallestHealth();
        this.ShowEnemie(this.minEnemy);

        Debug.Log("=============================================");
        Debug.Log("============EnemyFindEnemyWithLargestHealth: ");

        this.maxEnemy = this.EnemyFindEnemyWithLargestHealth();
        this.ShowEnemie(this.maxEnemy);

        Debug.Log("=============================================");
        Debug.Log("============QuickSort: ");
        this.QuickSort(enemiesSort, 0, enemies.Count - 1);



    }

    protected void LoadEnemies()
    {
        foreach (Transform child in transform)
        {
            EnemyAbstract enemy = child.GetComponent<EnemyAbstract>();
            this.enemies.Add(enemy);
        }
    }



    protected void ShowEnemies()
    {
        foreach (EnemyAbstract enemy in this.enemies)
        {
            Debug.Log(enemy.name + " hp: " + enemy.GetHp() + " / isDead: " + enemy.IsDead());
        }
    }

    protected void ShowEnemie(EnemyAbstract enemy)
    {
      
        
            Debug.Log(enemy.name + " hp: " + enemy.GetHp() + " / isDead: " + enemy.IsDead());
        
    }

    //----------------------Edit below here --------------------
    public EnemyAbstract EnemyFindEnemyWithSmallestHealth()
    {
     if(enemies == null || enemies.Count == 0)
        {
            return null;
        }
     EnemyAbstract minEnemy = enemies[0];
        foreach (EnemyAbstract enemy in enemies)
        {
            if(enemy.Health < minEnemy.Health)
            {
                minEnemy = enemy;
            }

        }
        return minEnemy;


    }

    public EnemyAbstract EnemyFindEnemyWithLargestHealth()
    {
        if (enemies == null || enemies.Count == 0)
        {
            return null;
        }
        EnemyAbstract maxEnemy = enemies[0];
        foreach (EnemyAbstract enemy in enemies)
        {
            if (enemy.Health > maxEnemy.Health)
            {
                maxEnemy = enemy;
            }

        }
        return maxEnemy;
    }

    //----------------------Edit above here --------------------

    public  void QuickSort(List<EnemyAbstract> enemies, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(enemies, left, right);
            QuickSort(enemies, left, pivotIndex - 1);
            QuickSort(enemies, pivotIndex + 1, right);
        }
    }

    private  int Partition(List<EnemyAbstract> enemies, int left, int right)
    {
        
      
        EnemyAbstract pivot = enemies[right];  // Chọn phần tử cuối cùng làm chốt (pivot)
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (enemies[j].Health < pivot.Health) // Sắp xếp theo health
            {
                i++;
                Swap(enemies, i, j);
            }
        }

        Swap(enemies, i + 1, right);
        return i + 1;
    }

    private  void Swap(List<EnemyAbstract> enemies, int i, int j)
    {
        EnemyAbstract temp = enemies[i];
        enemies[i] = enemies[j];
        enemies[j] = temp;
    }

}
