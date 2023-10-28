using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Text Result;
    public Image AIChoice;
    public int val;

    public string[] Choices;

    public Sprite Rock, Paper, Sci;

    public void Play(string myChoice) {
        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoice) {

            case "Rock":
                switch (myChoice) {

                    case "Rock":
                        Result.text = "Empate";

                        break;

                    case "Paper":
                        Result.text = "Vitoria";
                        break;

                    case "Sci":
                        Result.text = "Derrota";
                        break;

                }
                AIChoice.sprite = Rock;
                break;

            case "Paper":
                switch (myChoice) {

                    case "Rock":
                        Result.text = "Derrota";

                        break;

                    case "Paper":
                        Result.text = "Empate";
                        break;

                    case "Sci":
                        Result.text = "Vitoria";
                        break;

                }
                AIChoice.sprite = Paper;
                break;
            case "Sci":
                switch (myChoice) {

                    case "Rock":
                        Result.text = "Vitoria";

                        break;

                    case "Paper":
                        Result.text = "Derrota";
                        break;

                    case "Sci":
                        Result.text = "Empate";
                        break;

                }
                AIChoice.sprite = Sci;
                break;

            default:
                break;
        }
    }

}
