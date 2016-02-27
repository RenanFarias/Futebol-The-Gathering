using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public Draggable.Slot typeCard = Draggable.Slot.PERSONAGEM;


	public void OnPointerEnter(PointerEventData eventData){		
	}

	public void OnDrop(PointerEventData eventData){			
		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();

		if (d.typeCard == typeCard) {
			d.parentToReturnTo = this.transform;
		}
	}


	//troca a referencia daonde a carta irá ficar com base no tipo
	public void OnPointerExit(PointerEventData eventData){
		
	}
}
