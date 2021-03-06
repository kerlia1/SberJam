using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    //Объекты, через которые проходит взаимодействие
    GameObject player;
    GameObject enemy;
    [SerializeField] GameObject gameController;

    // Тут переменные связанные с классом игрок
    int playerHp;

    //Переменные связанные с классами
    private float playerDamagePerClick;


    private void Awake()
    {
        Init();
    }

    /// <summary>
    /// Инициализация всех параметров.
    /// </summary>
    public void Init()
    {
        player = GameObject.FindWithTag("Player");
        playerHp = player.GetComponent<Player>().MentalHealth;
        playerDamagePerClick = player.GetComponent<Player>().DamagePerClick;
    }

    private void Update()
    {
        if (gameController.GetComponent<GameController>().isGameStarted)
        {
            enemy = GameObject.FindWithTag("Enemy");
        }
    }


    /// <summary>
    /// Наносит урон при клике
    /// </summary>
    public void DamageEnemyOnClick()
    {
        enemy.GetComponent<Enemy>().EnemyHealth -= playerDamagePerClick;
        Debug.Log(enemy.GetComponent<Enemy>().EnemyHealth);
    }
}