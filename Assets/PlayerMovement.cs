using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    int moedas;
    public int vidaAtual = 50;
    public int vidaMaxima = 100;

    [SerializeField] private AudioClip somMoeda;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Moeda"))
        
        //    moedas += other.GetComponent<Moeda>().valor;
        //}

    }

    [ContextMenu("Pegou Moeda")]
    public void PegouMoeda()
    {
        moedas += Moeda.valor;
        //AudioManager.Instance.efeitosSonoros.Play();
        AudioManager.Instance.TocarSom(somMoeda);
    }
}
