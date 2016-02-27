using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public Transform parentToReturnTo = null;

	GameObject placeholder = null;

	public enum Slot{ PERSONAGEM, BONUS , CANTCHANGE	};
	public Slot typeCard = Slot.PERSONAGEM;


	//faz a referencia para onde a carta irá cair depois de solta
	public void OnBeginDrag(PointerEventData eventData){
		placeholder = new GameObject ();
		placeholder.transform.SetParent (this.transform.parent);
		LayoutElement le = placeholder.AddComponent<LayoutElement> ();
		le.preferredWidth = this.GetComponent<LayoutElement> ().preferredWidth;
		le.preferredHeight = this.GetComponent<LayoutElement> ().preferredHeight;
		le.flexibleWidth = 0;
		le.flexibleHeight = 0;

		placeholder.transform.SetSiblingIndex (this.transform.GetSiblingIndex());

		parentToReturnTo = this.transform.parent; 
		this.transform.SetParent(this.transform.parent.parent);

		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}


	//faz a carta se mover junto ao cursor
	public void OnDrag(PointerEventData eventData){		
		this.transform.position = eventData.position;
	}


	//coloca a carta dentro do painel pai.
	public void OnEndDrag(PointerEventData eventData){
		this.transform.SetParent (parentToReturnTo);

		Destroy (placeholder);
		GetComponent<CanvasGroup>().blocksRaycasts = true;
	}
}
	