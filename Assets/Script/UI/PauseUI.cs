using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    [SerializeField]private GameObject pauseUI;
    [SerializeField]private WitchGameManager gameManager;
    [SerializeField]private GameInput gameInput;
    
    [SerializeField]private float escapeCooldownTimerMax, inputCoolDownTimerMax;
    private float escapeCooldownTimer = 0, inputCooldownTimer = 0;
    [SerializeField]private GameObject[] selectArrowsPause;
    private int selectionPause;
    [SerializeField]private GameObject musicSlider, SoundSlider;
    private bool isMusicOn, isSoundOn;
    [SerializeField]private SoundManager soundManager;
    [SerializeField]private BGMManager bgmManager;

    void Start()
    {
        
        selectionPause = 0;
        UpdateSelectArrowPause();
        HideUI();
    }

    // Update is called once per frame
    
    void Update()
    {
        if(bgmManager == null){
            // Debug.Log("lah");
            bgmManager = GameObject.FindWithTag("Manager").GetComponent<BGMManager>();
            // Debug.Log(GameObject.FindWithTag("Manager"));
        }
        if(gameManager.IsInGame()){
            if(gameInput.GetInputEscape() && escapeCooldownTimer <= 0){
                
                ShowUI();
                gameManager.PauseGame();
                escapeCooldownTimer = escapeCooldownTimerMax;
            }  
            else if(escapeCooldownTimer > 0){
                escapeCooldownTimer -= Time.deltaTime;
            }
            
            
        }
        else if(gameManager.isPause()){
            if(gameInput.GetInputEscape() && escapeCooldownTimer <= 0){
                HideUI();
                gameManager.PauseGame();
                escapeCooldownTimer = escapeCooldownTimerMax;
            }
            else if(escapeCooldownTimer > 0){
                escapeCooldownTimer -= Time.deltaTime;
            }
            Vector2 keyInputArrow = gameInput.GetInputArrow();
            moveSelection_option(keyInputArrow);
            if(gameInput.GetInputSelectItemForCauldron() && inputCooldownTimer <= 0){
                inputCooldownTimer = inputCoolDownTimerMax;
                Select_Option();
            }
            if(isMusicOn && keyInputArrow.x == 1){
                bgmManager.UpdateBGM_Volume(0.1f);
            }
            else if(isMusicOn && keyInputArrow.x == -1){
                bgmManager.UpdateBGM_Volume(-0.1f);
            }
            if(isSoundOn && keyInputArrow.x == 1){
                soundManager.UpdateSound_Volume(0.1f);
            }
            else if(isSoundOn && keyInputArrow.x == -1){
                soundManager.UpdateSound_Volume(-0.1f);
            }

            if(inputCooldownTimer > 0){
                inputCooldownTimer--;
            }


            
        }
        else{
            escapeCooldownTimer = escapeCooldownTimerMax;
        }
        
    }
    private void moveSelection_option(Vector2 keyInputArrow){
        if(!isMusicOn && !isSoundOn){
            if(keyInputArrow.y == 1 && selectionPause > 0 ){
                selectionPause--;
            }
            else if(keyInputArrow.y == -1 && selectionPause < selectArrowsPause.Length-1){
                selectionPause++;
            }
            
            UpdateSelectArrowPause();
        }
        
    }
    private void UpdateSelectArrowPause(){
        foreach(GameObject selectarrow in selectArrowsPause){
            selectarrow.SetActive(false);
        }
        selectArrowsPause[selectionPause].SetActive(true);
    }

    private void ShowUI(){
        pauseUI.SetActive(true);
    }
    private void HideUI(){
        isMusicOn = false;
        isSoundOn = false;
        musicSlider.gameObject.SetActive(false);
        SoundSlider.gameObject.SetActive(false);
        pauseUI.SetActive(false);
    }

    private void Select_Option(){
        if(selectionPause == 0){
            HideUI();
            gameManager.PauseGame();
            escapeCooldownTimer = escapeCooldownTimerMax;
            
        }
        else if(selectionPause == 1){
            if(isMusicOn){
                musicSlider.gameObject.SetActive(false);
                isMusicOn = false;
            }
            else if(!isMusicOn){
                musicSlider.gameObject.SetActive(true);
                isMusicOn = true;
            }
            
        }
        else if(selectionPause == 2){
            if(isSoundOn){
                SoundSlider.gameObject.SetActive(false);
                isSoundOn = false;
            }
            else if(!isSoundOn){
                SoundSlider.gameObject.SetActive(true);
                isSoundOn = true;
            }
        }
        else if(selectionPause == 3){
            bgmManager.DestroyInstance();
            SceneManager.LoadScene("MainMenu");
        }
    }
    public Slider GetBGMSlider(){
        return musicSlider.GetComponent<Slider>();
    }


}
