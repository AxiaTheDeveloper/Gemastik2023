using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // private void playerInventory_OnUpdateUI(object sender, EventArgs e)
    // {
    //     //updateee ui
    // }

    // private void inventoryInput_OnQuitInventory(object sender, EventArgs e)
    // {
    //     HideUI();
    // }

    // public void CreateInventoryUI(int size){
    //     for(int i=0;  i < size;i++){
    //         InventoryItemUI UI_Item = Instantiate(inventItemUI, contentPanel);
    //         UI_ItemList.Add(UI_Item);
    //     }
    //     UI_ItemList[selectItem].SelectItem();
    //     // inventUIDesc.SetItemDataDesc(); diisii~~~
    // }
    // public void UpdateVisualInventorySlot(int position, InventorySlot item){
    //     Debug.Log(position);
    //     if(!item.itemSO){
    //         UI_ItemList[position].ResetData();
    //     }
    //     else{
    //         UI_ItemList[position].SetItemData(item.itemSO,item.quantity);
    //     }
        
    // }
    // public void UpdateVisual_InventDescription(){
    //     if(UI_ItemList[selectItem].IsEmpty()){
    //         inventUIDesc.EmptyDescUI();
    //     }
    //     else{
    //         ItemScriptableObject item = UI_ItemList[selectItem].GetItemData();
    //         inventUIDesc.SetItemDataDesc(item.itemSprite,item.name,item.Desc);
    //     }
    // }

    // //Urusan SelecItem
    // public void SelectItemRight(){
    //     //ini kalo mo lurus terus
    //     // if(selectItem < inventorySize - 1){
    //     //     UI_ItemList[selectItem].DeselectItem();
    //     //     selectItem++;
    //     //     UI_ItemList[selectItem].SelectItem();
    //     // }
    //     // else if(selectItem == inventorySize - 1){
    //     //     UI_ItemList[selectItem].DeselectItem();
    //     //     selectItem = 0;
    //     //     UI_ItemList[selectItem].SelectItem();
    //     // }

    //     //ini kalo mo per kolom aja

    //     keepMoveRight = true;
    //     int selectItemNow = 0;// ini buat tau dia ada di row mana sih
    //     for(int i=0;i<totalRow;i++){
    //         selectItemNow = i * totalColumn;
    //         if(selectItem == (totalColumn - 1 + selectItemNow)){
    //             keepMoveRight = false;
    //             break;
    //         }
    //     }
    //     if(keepMoveRight){
    //         UI_ItemList[selectItem].DeselectItem();
    //         selectItem++;
    //         UI_ItemList[selectItem].SelectItem();
    //     }
    //     else{
    //         UI_ItemList[selectItem].DeselectItem();
    //         selectItem = 0 + selectItemNow;
    //         UI_ItemList[selectItem].SelectItem();
    //     }
        
    //     // inventUIDesc.SetItemDataDesc(); diisii~~~
        
    // }
    // public void SelectItemLeft(){
    //     //ini kalo mo lurus terus
    //     // if(selectItem > 0){
    //     //     UI_ItemList[selectItem].DeselectItem();
    //     //     selectItem--;
    //     //     UI_ItemList[selectItem].SelectItem();
    //     // }
    //     // else if(selectItem == 0){
    //     //     UI_ItemList[selectItem].DeselectItem();
    //     //     selectItem = inventorySize -1;
    //     //     UI_ItemList[selectItem].SelectItem();
    //     // }

    //     //ini kalo mo per kolom aja

    //     keepMoveLeft = true;
    //     int selectItemNow = 0;// ini buat tau dia ada di row mana sih
    //     for(int i=0;i<totalRow;i++){
    //         selectItemNow = i * totalColumn;
    //         if(selectItem == (0 + selectItemNow)){
    //             keepMoveLeft = false;
    //             break;
    //         }
    //     }
    //     if(keepMoveLeft){
    //         UI_ItemList[selectItem].DeselectItem();
    //         selectItem--;
    //         UI_ItemList[selectItem].SelectItem();
    //     }
    //     else{
    //         UI_ItemList[selectItem].DeselectItem();
    //         selectItem = totalColumn-1 + selectItemNow;
    //         UI_ItemList[selectItem].SelectItem();
    //     }
    //     // inventUIDesc.SetItemDataDesc(); diisii~~~
    // }
    // public void SelectItemDown(){
    //     Debug.Log(selectItem + totalColumn);
    //     if(selectItem + totalColumn <= inventorySize - 1){
    //         UI_ItemList[selectItem].DeselectItem();
    //         selectItem += totalColumn;
    //         UI_ItemList[selectItem].SelectItem();
    //     }
    //     else if(selectItem + totalColumn > inventorySize - 1){
    //         UI_ItemList[selectItem].DeselectItem();
    //         selectItem -= (totalColumn * (totalRow-1));
    //         UI_ItemList[selectItem].SelectItem();
    //     }
    //     // inventUIDesc.SetItemDataDesc(); diisii~~~
    // }
    // public void SelectItemUp(){
    //     // Debug.Log(selectItem - totalColumn);
    //     if(selectItem - totalColumn >= 0){
    //         UI_ItemList[selectItem].DeselectItem();
    //         selectItem -= totalColumn;
    //         UI_ItemList[selectItem].SelectItem();
    //     }
    //     else if(selectItem - totalColumn < 0){
    //         UI_ItemList[selectItem].DeselectItem();
    //         selectItem += (totalColumn * (totalRow-1));
    //         UI_ItemList[selectItem].SelectItem();
    //     }
    //     // inventUIDesc.SetItemDataDesc(); diisii~~~
    // }
    // public void ShowUI(){
    //     gameManager.ChangeInterfaceType(2);

    //     gameObject.SetActive(true);
    //     inventUIDesc.EmptyDescUI();
    // }
    // public void HideUI(){
    //     gameManager.ChangeToInGame();

    //     gameObject.SetActive(false);
        
    // }

}
