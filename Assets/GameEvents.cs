using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;


    [SerializeField] private PlayerMovement player;


    private void Awake()
    {
        Instance = this;
    }

    public void InvokeMethod(string method, float delay)
    {
        Invoke(method, delay);
    }


    private void RecuperarVida()
    {
        player.vidaAtual = player.vidaMaxima;
    }
    
}
