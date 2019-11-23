using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

using UnityEngine.UIElements;

using UnityEngine.SceneManagement;

using UnityEngine.EventSystems;



public class PlayerInput : MonoBehaviour

{



    public GameObject camera;

    public GameObject descriptionPanel;
    public GameObject descriptionPanelText;

    public GameObject toolIcon;
    public GameObject abandonIcon;
    public GameObject grassIcon;
    public GameObject lightsIcon;
    public GameObject smokeIcon;

    public GameObject birdIcon;
    public GameObject treeIcon;
    public GameObject dogIcon;
    public GameObject wellIcon;
    public GameObject groundIcon;



    private bool toolsSelected;
    private bool grassSelected;
    private bool abandonSelected;
    private bool lightsSelected;
    private bool smokeSelected;

    private bool birdSelected;
    private bool treeSelected;
    private bool dogSelected;
    private bool wellSelected;
    private bool groundSelected;


    public string selectedObject = "";



    // Start is called before the first frame update

    void Start()
    {

        toolsSelected = false;
        grassSelected = false;
        abandonSelected = false;
        lightsSelected = false;
        smokeSelected = false;

        birdSelected = false;
        treeSelected = false;
        dogSelected = false;
        wellSelected = false;
        groundSelected = false;

    }



    // Update is called once per frame

    void Update()
    {

        m_SelectObject();


        if (toolsSelected == true &&
             grassSelected == true &&
             abandonSelected == true &&
             lightsSelected == true &&
             smokeSelected == true)
        {
            SceneManager.LoadScene("level2");
        }
            if (birdSelected == true &&
             treeSelected == true &&
             dogSelected == true &&
             wellSelected == true &&
             groundSelected == true)
            {
                SceneManager.LoadScene("level3");
            }
    }



    private void m_SelectObject()
    {



        RaycastHit hit = new RaycastHit();



        if (Input.GetMouseButtonDown(0))
        {


            if (EventSystem.current.IsPointerOverGameObject())
                return;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);



            if (Physics.Raycast(ray, out hit))
            {



                GameObject go = hit.transform.gameObject;

                Animator cameraAnimator = camera.GetComponent<Animator>();
                Animator descriptionPanelAnimator = descriptionPanel.GetComponent<Animator>();

                Text descriptionText = descriptionPanelText.GetComponent<Text>();

                




                switch (selectedObject)

                {

                    case "Fork Lift":

                        cameraAnimator.Play("CameraMoveBackFromForkLift");
                        descriptionPanelAnimator.Play("DescriptionPanelSlideIn");

                        selectedObject = "";

                        break;

                    case "Abandon":

                        cameraAnimator.Play("CameraMoveBackFromAbandon");
                        descriptionPanelAnimator.Play("DescriptionPanelSlideIn");

                        selectedObject = "";

                        break;
                    
                    case "Grass":

                        cameraAnimator.Play("CameraMoveBackFromGrass");
                        descriptionPanelAnimator.Play("DescriptionPanelSlideIn");

                        selectedObject = "";

                        break;
                   
                    case "Lights":

                        cameraAnimator.Play("CameraMoveBackFromLights");
                        descriptionPanelAnimator.Play("DescriptionPanelSlideIn");

                        selectedObject = "";

                        break;

                    case "Smoke":

                        cameraAnimator.Play("CameraMoveBackFromSmoke");
                        descriptionPanelAnimator.Play("DescriptionPanelSlideIn");

                        selectedObject = "";

                        break;
                    
                    case "Tools":

                        cameraAnimator.Play("CameraMoveBackFromTools");
                        descriptionPanelAnimator.Play("DescriptionPanelSlideIn");

                        selectedObject = "";

                        break;
                    case "Dog":

                        cameraAnimator.Play("CameraMoveBackFromDog");
                        descriptionPanelAnimator.Play("DescriptionPanelSlideIn");

                        selectedObject = "";

                        break;

                    case "Bird":

                        cameraAnimator.Play("CameraMoveBackFromBird");
                        descriptionPanelAnimator.Play("DescriptionPanelSlideIn");

                        selectedObject = "";

                        break;
                    case "Tree":

                        cameraAnimator.Play("CameraMoveBackFromTree");
                        descriptionPanelAnimator.Play("DescriptionPanelSlideIn");

                        selectedObject = "";

                        break;
                    case "Well":

                        cameraAnimator.Play("CameraMoveBackFromWell");
                        descriptionPanelAnimator.Play("DescriptionPanelSlideIn");

                        selectedObject = "";

                        break;
                    case "Ground":

                        cameraAnimator.Play("CameraMoveBackFromGround");
                        descriptionPanelAnimator.Play("DescriptionPanelSlideIn");

                        selectedObject = "";

                        break;
                    default:

                        break;

                }



                if (go.CompareTag("Fork Lift"))

                {

                    cameraAnimator.Play("CameraMoveToForkLift");
                    
                   //descriptionText.text = "Grass - All Plants have roots that are used to abosrb water and other nutrients from the soil. Unfortunately, the soil has a limited amount of these resourcces, and that means that all the plants in  an area need to compete for these resources. Grass usually wins this fight, because it covers so much more surface area, it chokes the trees out.";
                   // descriptionPanelAnimator.Play("DescriptionPanelSlideOut");
                    
                    
                    selectedObject = "Fork Lift";

                }

                if (go.CompareTag("Grass"))

                {

                    cameraAnimator.Play("CameraMoveToGrass");

                    descriptionText.text = "All Plants have roots that are used to abosrb water and other nutrients from the soil.Unfortunately, the soil has a limited amount of these resourcces, and that means that all the plants in  an area need to compete for these resources. Grass usually wins this fight, because it covers so much more surface area, it chokes the trees out.";
                    descriptionPanelAnimator.Play("DescriptionPanelSlideOut");

                    Sprite grassActiveSprite = Resources.Load<Sprite>("ObjectIcons/Grass_Icon_Active");
                    UnityEngine.UI.Image grassIconImage = grassIcon.GetComponent<UnityEngine.UI.Image>();
                    grassIconImage.sprite = grassActiveSprite;

                    grassSelected = true;
                    selectedObject = "Grass";

                }

                if (go.CompareTag("Abandon"))

                {

                    cameraAnimator.Play("CameraMoveToAbandon");

                    descriptionText.text = "Frequently trees are felled to create space to make buildings. It is much better for the trees if we reused the space taken up by abandoned buildings, or just refurbished them (if possible). ";
                    descriptionPanelAnimator.Play("DescriptionPanelSlideOut");

                    Sprite abandonActiveSprite = Resources.Load<Sprite>("ObjectIcons/Abandon_Icon_Active");
                    UnityEngine.UI.Image abandonIconImage = abandonIcon.GetComponent<UnityEngine.UI.Image>();
                    abandonIconImage.sprite = abandonActiveSprite;

                    abandonSelected = true;
                    selectedObject = "Abandon";

                    

                }
             
                    if (go.CompareTag("Smoke"))

                    {

                        cameraAnimator.Play("CameraMoveToSmoke");

                        descriptionText.text = "Car or truck emissions effect plant life due to trees and other plants make their own food from carbon dioxide, water, sunlight, and elements found in soil  and then release oxygen for humans and animals to breathe. But exhaust fumes can also affect them by producing carbon monoxide, nitrogen dioxide (contributes to acidic rain), soot, and more.";
                        descriptionPanelAnimator.Play("DescriptionPanelSlideOut");

                        Sprite smokeActiveSprite = Resources.Load<Sprite>("ObjectIcons/Smoke_Icon_Active");
                        UnityEngine.UI.Image smokeIconImage = smokeIcon.GetComponent<UnityEngine.UI.Image>();
                        smokeIconImage.sprite = smokeActiveSprite;

                        smokeSelected = true;
                        selectedObject = "Smoke";

                    }
                
                if (go.CompareTag("Lights"))

                {

                    cameraAnimator.Play("CameraMoveToLights");

                    descriptionText.text = "The lighting on a construction site is liekly to be powered by generators which work by burning fuel and giving off harmful emissions, which can damage and pollute the local environment. Many insects are also frawn to light, but artificial lights can create a fatal attraction. Declining inspect populations negatively impacts all species that rely on insects for food or pollination.";
                    descriptionPanelAnimator.Play("DescriptionPanelSlideOut");

                    Sprite lightsActiveSprite = Resources.Load<Sprite>("ObjectIcons/Lights_Icon_Active");
                    UnityEngine.UI.Image lightsIconImage = lightsIcon.GetComponent<UnityEngine.UI.Image>();
                    lightsIconImage.sprite = lightsActiveSprite;

                    lightsSelected = true;
                    selectedObject = "Lights";

                }

                if (go.CompareTag("Tools"))

                {

                    cameraAnimator.Play("CameraMoveToTools");

                    descriptionText.text = "Many caution signs are put up where construction or facilities that deal with hazardours or toxic material and disposables. These hazardous and toxic  material affects our environment especially trees which can suck up these harmful toxins and killing them. ";
                    descriptionPanelAnimator.Play("DescriptionPanelSlideOut");

                    Sprite toolActiveSprite = Resources.Load <Sprite>("ObjectIcons/Tool_Icon_Active");
                    UnityEngine.UI.Image toolIconImage = toolIcon.GetComponent<UnityEngine.UI.Image>();
                    toolIconImage.sprite = toolActiveSprite;

                    toolsSelected = true;
                    selectedObject = "Tools";

                }

                if (go.CompareTag("Dog"))

                {

                    cameraAnimator.Play("CameraMoveToDog");

                    descriptionText.text = "Certain herbivores dig up or eat seeds before they make it into the ground, preventing tree grouwth before it even begins.";
                    descriptionPanelAnimator.Play("DescriptionPanelSlideOut");

                    Sprite dogActiveSprite = Resources.Load<Sprite>("ObjectIcons/Dog_Icon_Active");
                    UnityEngine.UI.Image dogIconImage = dogIcon.GetComponent<UnityEngine.UI.Image>();
                    dogIconImage.sprite = dogActiveSprite;

                    dogSelected = true;
                    selectedObject = "Dog";

                }

                if (go.CompareTag("Tree"))

                {

                    cameraAnimator.Play("CameraMoveToTree");

                    descriptionText.text = "Due to the lack of water in the desert, the dry wood is excellent fuel for a fire.";
                    descriptionPanelAnimator.Play("DescriptionPanelSlideOut");

                    Sprite treeActiveSprite = Resources.Load<Sprite>("ObjectIcons/Tree_Icon_Active");
                    UnityEngine.UI.Image treeIconImage = treeIcon.GetComponent<UnityEngine.UI.Image>();
                    treeIconImage.sprite = treeActiveSprite;

                    treeSelected = true;
                    selectedObject = "Tree";

                }

                if (go.CompareTag("Ground"))

                {

                    cameraAnimator.Play("CameraMoveToGround");

                    descriptionText.text = "The desert floor is often sandy, rocky, or filled with clay, and in the case of the southwest United States, is very alkaline. These characteristics make it difficult for trees to grow, because most trees we are familiar with require a more acidic soil, and much more water than the desert can provide.";
                    descriptionPanelAnimator.Play("DescriptionPanelSlideOut");

                    Sprite groundActiveSprite = Resources.Load<Sprite>("ObjectIcons/Ground_Icon_Active");
                    UnityEngine.UI.Image groundIconImage = groundIcon.GetComponent<UnityEngine.UI.Image>();
                    groundIconImage.sprite = groundActiveSprite;

                    groundSelected = true;
                    selectedObject = "Ground";

                }

                if (go.CompareTag("Well"))

                {

                    cameraAnimator.Play("CameraMoveToWell");

                    descriptionText.text = "Heat from the sun casees water to evaporate, dehydrating the trees. This makes it difficult for the trees to create enought food to survive, while also increasing the risk of fires.";
                    descriptionPanelAnimator.Play("DescriptionPanelSlideOut");

                    Sprite wellActiveSprite = Resources.Load<Sprite>("ObjectIcons/Well_Icon_Active");
                    UnityEngine.UI.Image wellIconImage = wellIcon.GetComponent<UnityEngine.UI.Image>();
                    wellIconImage.sprite = wellActiveSprite;

                    wellSelected = true;
                    selectedObject = "Well";

                }

                if (go.CompareTag("Bird"))

                {

                    cameraAnimator.Play("CameraMoveToBird");

                    descriptionText.text = "As animals leave the area populated by trees, the trees can no longer use them to speread their seeds around, making it more difficult to cover more area.";
                    descriptionPanelAnimator.Play("DescriptionPanelSlideOut");

                    Sprite birdActiveSprite = Resources.Load<Sprite>("ObjectIcons/Bird_Icon_Active");
                    UnityEngine.UI.Image birdIconImage = birdIcon.GetComponent<UnityEngine.UI.Image>();
                    birdIconImage.sprite = birdActiveSprite;

                    birdSelected = true;
                    selectedObject = "Bird";

                }



            }

        }



    }

}