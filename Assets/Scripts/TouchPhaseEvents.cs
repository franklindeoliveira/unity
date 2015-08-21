using UnityEngine;
using System.Collections;

public class TouchPhaseEvents : MonoBehaviour {

	public UnityEngine.UI.Text beganValue;
	public UnityEngine.UI.Text canceledValue;
	public UnityEngine.UI.Text endedValue;
	public UnityEngine.UI.Text movedValue;
	public UnityEngine.UI.Text stationaryValue;

	private int beganCount;
	private int canceledCount;
	private int endedCount;
	private int movedCount;
	private int stationaryCount;

	// Use this for initialization
	void Start () {
		beganCount = 0;
		canceledCount = 0;
		endedCount = 0;
		movedCount = 0;
		stationaryCount = 0;
	}
	
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
				case TouchPhase.Began:
					beganCount++;
					beganValue.text = beganCount.ToString();
					break;
				case TouchPhase.Canceled:
					canceledCount++;
					canceledValue.text = canceledCount.ToString();
					break;
				case TouchPhase.Ended:
					endedCount++;
					endedValue.text = endedCount.ToString();
					break;
				case TouchPhase.Moved:
					movedCount++;
					movedValue.text = movedCount.ToString();
					break;
				case TouchPhase.Stationary:
					stationaryCount++;
					stationaryValue.text = stationaryCount.ToString();
					break;				
			}
		}
	}


}
