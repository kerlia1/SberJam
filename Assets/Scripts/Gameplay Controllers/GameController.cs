using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Тут объекты, через которые будет идти взаимодействие
    GameObject player = GameObject.FindGameObjectWithTag("Player");
    GameObject enemy;
    GameObject UpgradePanel;

    // Тут переменные связанные с классом игрок
    int playerHp;


    private void Awake()
    {
        Init();
    }


    /// <summary>
    /// Инициализация всех параметров.
    /// </summary>
    public void Init()
    {
        playerHp = player.GetComponent<Player>().MentalHealth;
    }

    public bool Lose()
    {
        return false;
    }
}
