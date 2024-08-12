using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingButton : MonoBehaviour
{
    public Button myButton; // Referência ao botão
    private Color[] colors = { Color.red, Color.green, Color.blue }; // Cores primárias
    private int currentColorIndex = 0;
    public float colorChangeInterval = 1.5f; // Intervalo de tempo em segundos para mudança de cor
    private bool canChangeColor = true; // Controle para o intervalo de tempo

    void Start()
    {
        if (myButton == null)
        {
            Debug.LogError("Nenhum botão foi atribuído!");
            return;
        }

        myButton.image.color = colors[currentColorIndex]; // Define a cor inicial do botão
        myButton.onClick.AddListener(OnButtonClick); // Adiciona a função ao evento de clique do botão
    }

    void OnButtonClick()
    {
        if (canChangeColor)
        {
            ChangeColor();
            StartCoroutine(ResetColorChangeAbility());
        }
    }

    void ChangeColor()
    {
        currentColorIndex = (currentColorIndex + 1) % colors.Length; // Alterna entre as cores
        myButton.image.color = colors[currentColorIndex]; // Aplica a cor ao botão
    }

    IEnumerator ResetColorChangeAbility()
    {
        canChangeColor = false; // Impede a mudança de cor até o intervalo passar
        yield return new WaitForSeconds(colorChangeInterval); // Espera o intervalo de tempo
        canChangeColor = true; // Permite a mudança de cor novamente
    }

}
