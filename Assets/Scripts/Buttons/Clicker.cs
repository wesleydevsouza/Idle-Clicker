using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    void ManualIncrement()
    {
        if (GameController.gameController.gold <= 0) {
            GameController.gameController.gold++;

        } else {
            GameController.gameController.gold = GameController.gameController.gold + (GameController.gameController.prodManual * GameController.gameController.qtdManualUpg);
            Debug.Log("Prod Manual: " + GameController.gameController.prodManual + " Qtd Up: " + GameController.gameController.qtdManualUpg);
        }

        Debug.Log(GameController.gameController.gold);
    }

    void TextUpdate()
    {
        GameController.gameController.Result.text = GameController.gameController.gold.ToString();
    }

    void Start()
    {
        GameController.gameController.btnClick.onClick.AddListener(ManualIncrement);

    }

    // Update is called once per frame
    void Update()
    {
        TextUpdate();
    }
}
