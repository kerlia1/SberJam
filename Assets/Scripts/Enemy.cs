using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    //Диапазон здоровья врага, нужно посчитать, сейчас значения взяты от балды
    //Здоровье должно быть кратно 5, поэтому значения маленькие, при инициализации
    // они скалируются (200 - 400)
    private int lowerHealthBound = 40;
    private int higherHealthBound = 80;
    
    private float health;
    /// <summary>
    /// Здоровье дедлайна. Снижается при клике и пассивно от улучшений
    /// </summary>
    public float Health { get => health; set { health = value; } }
    
    private void Awake() {
        Init();
    }
    
    /// <summary>
    /// Инициализация параметров при спавне врага
    /// </summary>
    public void Init() {
        Health = Random.Range(lowerHealthBound, higherHealthBound) * 5;
    }
}
