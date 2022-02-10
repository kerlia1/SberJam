using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour {
    //Объекты, через которые проходит взаимодействие
    GameObject player;
    GameObject enemy;
    
    //Переменные связанные с классами
    private float playerDamagePerClick;

    private void Awake() {
        Init();
    }


    /// <summary>
    /// Инициализация всех параметров.
    /// </summary>
    public void Init() {
        player = GameObject.Find("Player");
        enemy = GameObject.Find("Enemy");

        playerDamagePerClick = player.GetComponent<Player>().DamagePerClick;
    }

    /// <summary>
    /// Наносит урон при клике
    /// </summary>
    public void DamageEnemyOnClick() {
        enemy.GetComponent<Enemy>().Health -= playerDamagePerClick;
        Debug.Log(enemy.GetComponent<Enemy>().Health);
    }
}