using UnityEngine;
using UnityEngine.UI;

public class AutoClick : MonoBehaviour
{

    public int qtdAutoUpgrade, prodAuto, priceAutoUpg;
    public bool isAuto;
    public Button btnAuto;
    public Text txtAuto;
    
    void AutoIncrement()
    {

        if (isAuto == true)
        {
            Clicker.InstClicker.gold = Clicker.InstClicker.gold + prodAuto;

        }

    }
    
    void EnableAuto()   
    {
        if (isAuto == true)
        {
            //Func upgrade auto click
            
            if (Clicker.InstClicker.gold >= priceAutoUpg)
            {
                Clicker.InstClicker.gold -= priceAutoUpg;
                //PriceUpgrade();

                txtAuto.text = "Upgrade Auto " + priceAutoUpg + "$";

            }
            
            {
                Debug.Log("Gold insuficiente");
                return;

            }

        }
        else
        {
            if (Clicker.InstClicker.gold >= priceAutoUpg)
            {
                Clicker.InstClicker.gold -= priceAutoUpg;
                isAuto = true;

               // PriceUpgrade();


                //btnAuto.interactable = false;

            }
            else
            {
                Debug.Log("Gold insuficiente");
                return;

            }
        }

    }

    void PriceUpgrade()
    {
       
        priceAutoUpg = priceAutoUpg * qtdAutoUpgrade;
        qtdAutoUpgrade++;

        Debug.Log("Qtd Upgrade: " + qtdAutoUpgrade + "Preço: " + priceAutoUpg);
    }

    void Start()
    {
        btnAuto.onClick.AddListener(EnableAuto);
        InvokeRepeating("AutoIncrement", 1f, 1f);

        Debug.Log("Preço: " + priceAutoUpg);

    }


    void Update()
    {
        txtAuto.text = "Upgrade Auto " + priceAutoUpg + "$";
    }

}
