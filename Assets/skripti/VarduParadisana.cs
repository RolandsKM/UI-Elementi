using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VarduParadisana : MonoBehaviour {
	public string teksts;
	public GameObject IevadesLauks;
	public GameObject TekstaAttelosana;
	private string[] fragmenti = {"Sveiks", "JaukuDienu", "PrieksTevi Redzēt", "Sup"};
	int indekss;
	public void UzglabaTekstu()
	{
		indekss = Random.Range(0, fragmenti.Length);
		teksts = IevadesLauks.GetComponent<InputField>().text;
		TekstaAttelosana.GetComponent<Text>().text = fragmenti[indekss] + teksts.ToUpper() + "!";


    }

}
