using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FinishWordDoFunction : MonoBehaviour
{
    //buat kirim sinyal aja kalo uda selesai tergantung mo ke siapa
    public event EventHandler OnFinishChestWord, OnStopCauldronFire, OnTumbuk;//ke chest, ke cauldron, ke penumbuk
    public enum Type{
        AddObject, Cauldron, Chest, Penumbuk
    }
    public Type type;


    // [SerializeField]private PlayerInventory playerInventory;
    // [SerializeField]private ItemScriptableObject itemYangNambah;
    // [SerializeField]private int quantity;


    private void Start() {        
       
    }
    public void WordFinisheds(){
        if(type == Type.AddObject){
            Debug.Log("yey");
        }
        else if(type == Type.Chest){
            OnFinishChestWord?.Invoke(this,EventArgs.Empty);
            // adds.WordFinished(playerInventory.GetPlayerInventory(), itemYangNambah, quantity);
        }
        else if(type == Type.Cauldron){
            OnStopCauldronFire?.Invoke(this,EventArgs.Empty);
        }
        else if(type == Type.Penumbuk){
            OnTumbuk?.Invoke(this,EventArgs.Empty);
        }
    }
}
