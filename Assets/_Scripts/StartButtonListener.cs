using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartButtonListener : MonoBehaviour {

    public Button startButtton;
    public Button resetButton;
	public Button elasticInelasticButton;

    public CarMovement car1;
    public CarMovement car2;
//
//    public SliderListener car2Slider;
//    public SliderListener car1MassSlider;
//    public SliderListener car2MassSlider;
//    public SliderListener car1PositionSlider;
//    public SliderListener car2PositionSlider;
	public Car1ControlListener incVelocityCar1;
	public Car1ControlListener decVelocityCar1;
	public Car1ControlListener incMassCar1;
	public Car1ControlListener decMassCar1;
	public Car1ControlListener incPositionCar1;
	public Car1ControlListener decPositionCar1;
	public Car2ControlListener incVelocityCar2;
	public Car2ControlListener decVelocityCar2;
	public Car2ControlListener incMassCar2;
	public Car2ControlListener decMassCar2;
	public Car2ControlListener incPositionCar2;
	public Car2ControlListener decPositionCar2;
    private Vector3 car1OriginalPosition;
    private Vector3 car2OriginalPosition;


//	public Button car1Decrease
    // Use this for initialization
    void Start ()
    {
        startButtton = GetComponent<Button>();

        //car1OriginalPosition = car1.transform.position;
        //car2OriginalPosition = car2.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void startMovement()
    {
        //car1OriginalPosition = car1.transform.position;
        //car2OriginalPosition = car2.transform.position;
        car1.xPosition = car1.transform.position;
        car2.xPosition = car2.transform.position;

//        car1Slider.ChangeCarVelocity();
//        car2Slider.ChangeCarVelocity();
//        car1MassSlider.ChangeCarMass();
//        car2MassSlider.ChangeCarMass();
//		incVelocity.IncreaseCarVelocity ();
//		decVelocity.DecreaseCarVelocity ();
        car1.addVelocity();
        car2.addVelocity();




        // Disables all sliders and the start button
//        car1Slider.GetComponent<Slider>().interactable = false;
//        car2Slider.GetComponent<Slider>().interactable = false;
//        car1MassSlider.GetComponent<Slider>().interactable = false;
//        car2MassSlider.GetComponent<Slider>().interactable = false;
//        car1PositionSlider.GetComponent<Slider>().interactable = false;
//        car2PositionSlider.GetComponent<Slider>().interactable = false;
        startButtton.interactable = false;
		elasticInelasticButton.interactable = false;
		incVelocityCar1.GetComponent<Button> ().interactable = false;
		decVelocityCar1.GetComponent<Button> ().interactable = false;
		incMassCar1.GetComponent<Button> ().interactable = false;
		decMassCar1.GetComponent<Button> ().interactable = false;
		incPositionCar1.GetComponent<Button> ().interactable = false;
		decPositionCar1.GetComponent<Button> ().interactable = false;
		incVelocityCar2.GetComponent<Button> ().interactable = false;
		decVelocityCar2.GetComponent<Button> ().interactable = false;
		incMassCar2.GetComponent<Button> ().interactable = false;
		decMassCar2.GetComponent<Button> ().interactable = false;
		incPositionCar2.GetComponent<Button> ().interactable = false;
		decPositionCar2.GetComponent<Button> ().interactable = false;

        //Enables the reset Button
        resetButton.interactable = true;


    }

    
}
