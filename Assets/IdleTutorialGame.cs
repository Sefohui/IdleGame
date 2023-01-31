using UnityEngine;
using UnityEngine.UI;

public class IdleTutorialGame : MonoBehaviour
{
    public Text coinsText;
    public double coins;

    public Text coinsPerSecText;
    public Text clickUpgrade1Text;
    public Text productionUpgrade1Text;

    public double coinsPerSecond;

    public double clickUpgrade1cost;
    public int clickUpgrade1Level;
    
    public double productionUpgrade1cost;
    public int productionUpgrade1Level;


    public void Start()
    {
        clickUpgrade1cost = 10;
        productionUpgrade1cost = 25;
    }

    public void Update()
    {
        coinsPerSecond = productionUpgrade1Level;

        coinsText.text = "Coins: " + coins;
        coinsPerSecText.text = coinsPerSecond + " coins/s";
    }

    public void Click()
    {
        coins += 1;
    }

}