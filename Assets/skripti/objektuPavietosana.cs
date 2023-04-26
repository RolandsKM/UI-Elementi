using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class objektuPavietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler{
    private RectTransform framsformKomponents;
    public Canvas Kanva;
    void Start()
    {
        framsformKomponents = GetComponent<RectTransform>();
    }
    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Izdarīts peles klišķis uz objekta!");

    }
    public void OnBeginDrag(PointerEventData notikums){
        Debug.Log("Uzsākta objektu vilkšana");
    }
    public void OnDrag(PointerEventData notikums)
    {
        Debug.Log("Notiek objektu Pārvietošana");
        framsformKomponents.anchoredPosition += notikums.delta / Kanva.scaleFactor;
    }
    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Pabeikta objektu vilkšana ");
    }
}
