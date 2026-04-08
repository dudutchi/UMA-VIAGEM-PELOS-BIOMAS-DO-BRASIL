using UnityEngine;
using TMPro;

[System.Serializable]
public class Pergunta
{
    public string enunciado;
    public string[] alternativas;
    public int respostaCorreta;
}

public class QuizManager : MonoBehaviour
{
    public TextMeshProUGUI textoPergunta;
    public TextMeshProUGUI[] textosAlternativas; // arrastar os textos dos botões aqui

    private Pergunta[] perguntas;
    private int perguntaAtual = 0;

    void Start()
    {
        // Criando perguntas direto no código
        perguntas = new Pergunta[]
        {
            new Pergunta
            {
                enunciado = "A Amazônia é o maior bioma do Brasil?",
                alternativas = new string[] { "A", "B", "C", "D" },
                respostaCorreta = 0
            },
            new Pergunta
            {
                enunciado = "O Cerrado é considerado uma savana?",
                alternativas = new string[] { "A", "B", "C", "D" },
                respostaCorreta = 3
            }
        };

        MostrarPergunta();
    }

    void MostrarPergunta()
    {
        Pergunta p = perguntas[perguntaAtual];

        textoPergunta.text = p.enunciado;

        // Atualiza as alternativas
        for (int i = 0; i < p.alternativas.Length; i++)
        {
            textosAlternativas[i].text = p.alternativas[i];
        }
    }

    public void Responder(int indice)
    {
        if (indice == perguntas[perguntaAtual].respostaCorreta)
        {
            Debug.Log("Acertou!");
        }
        else
        {
            Debug.Log("Errou!");
        }

        perguntaAtual++;

        if (perguntaAtual < perguntas.Length)
        {
            MostrarPergunta();
        }
        else
        {
            Debug.Log("Fim do quiz!");
        }
    }
}
