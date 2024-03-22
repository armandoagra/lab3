using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    [SerializeField] private AudioSource efeitosSonoros;
    public AudioClip acelerar, frear, bater, cair, moedas, dinheiro;



    private void Awake()
    {
        Instance = this;
    }
   
    public void TocarSom(AudioClip som)
    {
        efeitosSonoros.PlayOneShot(som);
    }
}
