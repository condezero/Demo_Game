using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ButtonController : MonoBehaviour {

	public Button button;
	public Text buttonText;

	public int PositionV;
	public int PositionH;

	private static float timing = 0f;
	public static int lastH = 0;
	public static int lastV = 0;
	public static int count = 1;

	private int baseScore = 10;

	private bool CanClickH()
	{
		if(lastH +3 == PositionH && lastV == PositionV) return true;
		if(lastH -3 == PositionH && lastV == PositionV) return true;
		return false;
	}

	private bool CanClickV(){
		if (lastV + 3 == PositionV && lastH == PositionH)
			return true;
		if (lastV - 3 == PositionV && lastH == PositionH)
			return true;

		return false;
	}

	private bool CanClickDiagonal(){
		if (lastV + 2 == PositionV && lastH + 2 == PositionH)
			return true;
		if (lastV - 2 == PositionV && lastH - 2 == PositionH)
			return true;
		if (lastV + 2 == PositionV && lastH - 2 == PositionH)
			return true;
		if (lastV - 2 == PositionV && lastH + 2 == PositionH)
			return true;
		return false;
	}

	public void SetSpace(){
		if (lastH == 0 && lastV == 0) {
			var a = new Countdown (){isCountingDown = true};

			SetTheValues ();
		} else if (CanClickV () || CanClickH () || CanClickDiagonal ()) {
			SetTheValues ();
		} 
	}



		private  void SetTheValues(){
		lastH = PositionH;
		lastV = PositionV;
		Debug.Log (PositionH.ToString());
		Debug.Log (PositionV.ToString());
		buttonText.text = count.ToString();
		count++;
		button.interactable = false;
	}

	private void Score(){
		
	}


}
