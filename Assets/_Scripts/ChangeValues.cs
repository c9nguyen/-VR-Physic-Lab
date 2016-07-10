using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeValues : MonoBehaviour {

	public Rigidbody car1;
	public Slider car1VelocitySlider;

	public Slider car2VelocitySlider;
	public Rigidbody car2;

	public Button testButton;





	private float car1Velocity;
	private float car1Mass;	
	private Vector3 car1StartingPos;

	private float car2Velocity;
	private float car2Mass;
	private Vector3 car2StartingPos;

	void Start()
	{
		car1 = car1.GetComponent<Rigidbody> ();
		car2 = car2.GetComponent<Rigidbody> ();

		car1Velocity = 0;
		car2Velocity = 0;

		car1Mass = 1;
		car2Mass = 1;

		car1.mass = car1Mass;
		car2.mass = car2Mass;

		car1StartingPos = car1.position;
		car2StartingPos = car2.position;
	}
		

	public void ChangeCar1Velocity(float newValue)
	{
		car1Velocity = newValue;
	}

//	public void OnValueChanged(float newValue)
//	{
//		car1Velocity = newValue;
//	}

	public void ChangeCar2Velocity (float newValue)
	{
		car2Velocity = newValue;
	}

	public void ChangeCar1Mass(float newValue)
	{
		car1Mass = newValue;
	}

	public void ChangeCar2Mass(float newValue)
	{
		car2Mass = newValue;
	}

	public void Test()
	{


		//If inelastic


		//If elastic


		//Set the masses
		car1.mass = car1Mass;
		car2.mass = car2Mass;

		//Apply the force
		car1.AddForce (0, 0, car1Velocity, ForceMode.VelocityChange);
		car2.AddForce (0, 0, car2Velocity, ForceMode.VelocityChange);


		//Disable test button
		testButton.interactable = false;


		//Disable sliders
		car1VelocitySlider.interactable = false;
		car2VelocitySlider.interactable = false;





	}

	public void Reset()
	{

		//Enable Test button
		testButton.interactable = true;


		//Enable Sliders
		car1VelocitySlider.interactable = true;
		car2VelocitySlider.interactable = true;

		//Stop cars from moving
		car1.velocity = new Vector3(0,0,0);
		car2.velocity = new Vector3 (0, 0, 0);

		//Reposition cars
		car1.position = car1StartingPos;
		car2.position = car2StartingPos;
	}
}



