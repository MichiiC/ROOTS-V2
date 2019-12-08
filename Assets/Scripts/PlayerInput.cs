using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

using UnityEngine.UIElements;

using UnityEngine.SceneManagement;

using UnityEngine.EventSystems;





public class PlayerInput : MonoBehaviour

{

    public GameObject CompleteLevelPanel;

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

    /*
    public RectTransform mPanelCompleteLevel;
    public Text mTxtCompleteLevel;
    public event EventHandler CompleteLevelEvent;
    private void CompleteLevel()
    {
        if (CompleteLevel != null)
            CompleteLevel(this, EventArgs.Empty);
    }
    */


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

    /*
    public bool CompleteLevel
    {
        get
        {
            if (selectedObject = "")
                return true;
        }
    }
    */

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

            if (CompleteLevelPanel != null && !CompleteLevelPanel.active) {
                bool isActive = CompleteLevelPanel.activeSelf;
                CompleteLevelPanel.SetActive(!isActive);
            }
        }
        if (birdSelected == true &&
         treeSelected == true &&
         dogSelected == true &&
         wellSelected == true &&
         groundSelected == true)
        {
            if (CompleteLevelPanel != null && !CompleteLevelPanel.active)
            {
                bool isActive = CompleteLevelPanel.activeSelf;
                CompleteLevelPanel.SetActive(!isActive);
            }
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
                    case "Jug":

                        cameraAnimator.Play("CameraMoveBackFromJug");
                        //descriptionPanelAnimator.Play("DescriptionPanelSlideIn");

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

                    descriptionText.text = "All plants have roots that are used to absorb water and other nutrients from the soil. Unfortunately, the soil has a limited amount of resources, and that means that all the plants in an area are in constant competition with each other. Also, some grasses, such as red fescue and bermudagrass, secrete chemicals that harm the growth of tree roots! (7)";
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

                    descriptionText.text = "It’s no secret that deforestation results in billions of trees being cut down each year. If we were to reuse and repurpose old, abandoned lots, we wouldn’t need to kill as many trees to make room for more buildings. (4) ";
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

                        descriptionText.text = "The compounds found within vehicle emissions can have a detrimental effect on the plants that are exposed to them. In fact, plants that have to deal with the stress of pollution don’t hold onto water as easily as healthy plants, making them more vulnerable to droughts. (6)";
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

                    descriptionText.text = "The lighting on a construction site is likely to be powered by generators which work by burning fuel and giving off harmful emissions. Many insects are also drawn to light, which can pull insects from their ecosystem, cause them to die of exhaustion, or make them easy prey. Declining insect populations negatively impacts all species that rely on insects for food or pollination. (1) (2) (3)";
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

                    descriptionText.text = "Depending on the type of construction, hazardous waste can be a real issue. Lead paint, batteries, and toxic chemicals, are only a small portion of what is thrown away at construction sites that have the potential to be dangerous. Especially if they aren’t disposed of properly, these materials can pose a serious threat to the local environment, between tainting the soil and poisoning wildlife. (5)";
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

                    descriptionText.text = "Certain herbivores dig up or eat seeds before they make it into the ground, preventing tree growth before it even begins. Trees aren’t even safe when fully grown. Some animals, such as squirrels and rabbits, eat the roots and bark of trees, preventing them from growing quickly and making them vulnerable to disease. (8)";
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

                    descriptionText.text = "Due to the lack of water in the desert, the dry wood is excellent fuel for a fire. Careless campers and lightning strikes can cause wildfires to rage in dry climates, and a strong breeze can cause an ecological crisis. (9) (10)";
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

                    descriptionText.text = "The desert floor is often sandy, rocky, or filled with clay, and in the case of the southwest United States, very alkaline. These characteristics make it difficult for trees to grow, because most trees more acidic soil, and much more water than the desert can provide. (11)";
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

                    descriptionText.text = "When hot climates have a drought, the upper roots of a tree will go into overdrive, trying to find every last molecule of water. If the soil stays dry, these roots will eventually die out, leaving the tree with a smaller overall root system. When rain eventually returns, this leaves the tree at a disadvantage. With lots of foliage and a lackluster root system, they can’t take full advantage of the water. If this pattern continues, the tree will eventually die. (12)";
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

                    descriptionText.text = "In an area with a drought, trees aren’t the only ones that need water. Animals will soon leave the area in search of water, and one of two things can happen. Either the pollinating animals migrate away, preventing the trees from spreading its seeds, or the predators in the area leave, allowing the herbivores in the area to run rampant, because they are able to get water from the leaves.";
                    descriptionPanelAnimator.Play("DescriptionPanelSlideOut");

                    Sprite birdActiveSprite = Resources.Load<Sprite>("ObjectIcons/Bird_Icon_Active");
                    UnityEngine.UI.Image birdIconImage = birdIcon.GetComponent<UnityEngine.UI.Image>();
                    birdIconImage.sprite = birdActiveSprite;

                    birdSelected = true;
                    selectedObject = "Bird";

                }
                if (go.CompareTag("Jug"))

                {

                    cameraAnimator.Play("CameraMoveToJug");

                    //descriptionText.text = "Grass - All Plants have roots that are used to abosrb water and other nutrients from the soil. Unfortunately, the soil has a limited amount of these resourcces, and that means that all the plants in  an area need to compete for these resources. Grass usually wins this fight, because it covers so much more surface area, it chokes the trees out.";
                    // descriptionPanelAnimator.Play("DescriptionPanelSlideOut");


                    selectedObject = "Jug";

                }



            }

        }



    }

}