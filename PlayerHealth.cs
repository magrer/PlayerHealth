using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    
    void Start()
    {
        currentHealth = maxHealth;
    }
    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log($"Игрок получил {damage} урона. Осталось здоровья: {currentHealth}");
        
        if (currentHealth <= 0)
        {
            Debug.Log("Игрок погиб!");
            // Тут можно перезагрузить сцену или показать game over
        }
    }
}