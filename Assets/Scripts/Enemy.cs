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
    public float Health { get => health; set => health = value; }

    private int timeToDo;
    /// <summary>
    /// Время, выдаваемое на то, чтобы сделать таску
    /// </summary>
    public int TimeToDo { get => timeToDo; set => timeToDo = value; }
    
    private string taskName;
    /// <summary>
    /// Название таска
    /// </summary>
    public string TaskName { get => taskName; set => taskName = value; }
    
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
