using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class INFO : MonoBehaviour
{

    //hello


    public GameObject defaultImage;
    public GameObject infoImage;
    public TextMeshProUGUI[] Values;
    public TextMeshProUGUI PlanetName;
    // Start is called before the first frame update
    void Start()
    {

        infoImage.SetActive(false);
        defaultImage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void changeValues(string t)
    {
        switch (t)
        {

            case "1":

                defaultImage.SetActive(false);
                PlanetName.text = "Mercury";
                Values[0].text = "1st";
                Values[1].text = "58 Million Km";
                Values[2].text = "1408 Hrs";
                Values[3].text = "88 Days";
                Values[4].text = "167°C";
                infoImage.SetActive(true);
                break;
            case "2":
                defaultImage.SetActive(false);
                PlanetName.text = "Venus";
                Values[0].text = "2nd";
                Values[1].text = "108 Million Km";
                Values[2].text = "5832 Hrs";
                Values[3].text = "225 Days";
                Values[4].text = "464°C";
                infoImage.SetActive(true);
                break;
            case "3":
                defaultImage.SetActive(false);
                PlanetName.text = "Earth";
                Values[0].text = "3rd";
                Values[1].text = "150 Million Km";
                Values[2].text = "24 Hrs";
                Values[3].text = "365 Days";
                Values[4].text = "15°C";
                infoImage.SetActive(true);
                break;
            case "4":
                defaultImage.SetActive(false);
                PlanetName.text = "Mars";
                Values[0].text = "4th";
                Values[1].text = "228 Million Km";
                Values[2].text = "25 Hrs";
                Values[3].text = "687 Days";
                Values[4].text = "-65°C";
                infoImage.SetActive(true);
                break;
            case "5":
                defaultImage.SetActive(false);
                PlanetName.text = "Jupiter";
                Values[0].text = "5th";
                Values[1].text = "778 Million Km";
                Values[2].text = "10 Hrs";
                Values[3].text = "4333 Days";
                Values[4].text = "-110°C";
                infoImage.SetActive(true);
                break;
            case "6":
                defaultImage.SetActive(false);
                PlanetName.text = "Saturn";
                Values[0].text = "6th";
                Values[1].text = "1.4 Billion Km";
                Values[2].text = "11 Hrs";
                Values[3].text = "10759 Days";
                Values[4].text = "-140°C";
                infoImage.SetActive(true);
                break;
            case "7":
                defaultImage.SetActive(false);
                PlanetName.text = "Uranus";
                Values[0].text = "7th";
                Values[1].text = "2.9 Billion Km";
                Values[2].text = "17 Hrs";
                Values[3].text = "30687 Days";
                Values[4].text = "-195°C";
                infoImage.SetActive(true);
                break;
            case "8":
                defaultImage.SetActive(false);
                PlanetName.text = "Neptune";
                Values[0].text = "8th";
                Values[1].text = "4.5 Billion Km";
                Values[2].text = "16 Hrs";
                Values[3].text = "60190 Days";
                Values[4].text = "-200°C";
                infoImage.SetActive(true);
                break;

            default:
                Debug.Log("default case");
                infoImage.gameObject.SetActive(false);

                defaultImage.gameObject.SetActive(true);
                break;
        }
    }
}
