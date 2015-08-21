using UnityEngine;
using System.Collections;

public class MoveObjetoTouch : MonoBehaviour {

	// Update is called once per frame
	void Update ()
	{
		// Se temos um ou mais dedos pressionando a tela.
		if (Input.touchCount > 0)
		{
			// Obtém apenas o primeiro dedo pressionado.
			var toque = Input.GetTouch(0);

			switch (toque.phase)
			{
				case TouchPhase.Began: case TouchPhase.Moved:
					/* Para converter a posição do toque na tela para posição do toque na unity é necessário 
					 * informar para o ScreenToWorldPoint a distância z do objeto até a câmera. */
					float distanciaCameraZ = transform.position.z - Camera.main.transform.position.z;
					Vector3 posicaoToque = new Vector3(toque.position.x, toque.position.y, distanciaCameraZ);
					transform.position = Camera.main.ScreenToWorldPoint(posicaoToque);
					break;
			}
		}
	}


}
