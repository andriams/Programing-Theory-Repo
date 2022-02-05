using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _isGameOver = false;
    [SerializeField] private GameObject UIGameOver;

    public bool IsGameOver { get => _isGameOver; }

    private void Start()
    {
        _isGameOver = false;
    }

    public void GameOver()
    {
        _isGameOver = true;
        UIGameOver.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
