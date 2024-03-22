using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogoManager : MonoBehaviour
{
    [SerializeField] private Image spritePersonagemImage;
    [SerializeField] private TMP_Text nomePersonagemText, dialogoText;
    [SerializeField] private DialogoCompleto dialogoCompletoAtual;
    [SerializeField] private GameObject dialogoPanel;
    private Dialogo dialogoAtual;
    private int dialogoAtualIndice = -1;
    

    private void Start()
    {
        ProximoDialogo();
        AtualizarUI();
    }

    // TO DO
    // OK --- em aula: evento
    // opções (pergunta/resposta)
    // reiniciar dialogo repetidos
    // typing effect
    // texto animado/efeitos
    // localização (simple localization)
    // efeitos sonoros especificos


    public void AtualizarUI()
    {
        spritePersonagemImage.sprite = dialogoAtual.spritePersonagem;
        nomePersonagemText.text = dialogoAtual.nomePersonagem;
        dialogoText.text = dialogoAtual.texto;
    }

    public void ProximoDialogo()
    {
        dialogoAtualIndice++;
        if (dialogoAtualIndice >= dialogoCompletoAtual.dialogos.Count)
        {
            // Encerra o dialogo
            Debug.Log("Fim de dialogo");
            dialogoPanel.SetActive(false);
        }
        else
        {
            dialogoAtual = dialogoCompletoAtual.dialogos[dialogoAtualIndice];
            if (dialogoAtual.evento != "")
            {
                GameEvents.Instance.InvokeMethod(dialogoAtual.evento, dialogoAtual.delayEvento);
            }
        }
        AtualizarUI();
    }

}
