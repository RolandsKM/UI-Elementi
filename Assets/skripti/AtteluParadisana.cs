using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {

	public GameObject binsImg;
	public GameObject lacitisImg;
	public GameObject omeImg;
	public GameObject masinaImg;
    public GameObject PaKreisiPoga;
    public GameObject PaLabiPoga;
    public GameObject mainigaisAttels;
    public Sprite[] AtteluMasivs;
    public GameObject sliderisIzmes;
    public GameObject slideriisRotacija;

    public void BinaAtelosana(bool vertiba)
	{
		binsImg.SetActive(vertiba);
        PaKreisiPoga.GetComponent<Toggle>().interactable = vertiba;
        PaLabiPoga.GetComponent<Toggle>().interactable = vertiba;

    }
    public void Lacattelosana(bool vertiba)
    {
        lacitisImg.SetActive(vertiba);

    }
    public void Omeattelosana(bool vertiba)
    {
        omeImg.SetActive(vertiba);

    }
    public void Masinaattelosana(bool vertiba)
    {
        masinaImg.SetActive(vertiba);

    }
    public void PaKreisiBeans()
    {
        binsImg.transform.localScale = new Vector2(1, 1);

    }
    public void PaLabiBeans()
    {
        binsImg.transform.localScale = new Vector2(-1, 1);

    }
    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)

            mainigaisAttels.GetComponent<Image>().sprite = AtteluMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels.GetComponent<Image>().sprite = AtteluMasivs[1];
        else if (skaitlis == 2)
            mainigaisAttels.GetComponent<Image>().sprite = AtteluMasivs[2];
        else
            Debug.Log("Nev piesaistītais attels");
    }
    public void mainitlielumu()
    {
        float pasreizejaVertiba = sliderisIzmes.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1f*pasreizejaVertiba, 1f * pasreizejaVertiba);
    }
    public void mainitrotaciju()
    {
        float pasreizejavertiba = slideriisRotacija.GetComponent<Slider>().value;
        mainigaisAttels.transform.localRotation = Quaternion.Euler(0,0, pasreizejavertiba * 3600000000000000 );
    }
}
