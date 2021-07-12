import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

import { FormGroup,FormBuilder, Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class StockService {

  constructor(private fb:FormBuilder,private http:HttpClient) { }

  stockForm : FormGroup  = this.fb.group({
    productName:['',Validators.required],
    partNumber:['',Validators.required],
    productLabel:['',Validators.required],
    startingInventory:[,Validators.required],
    inventoryRecieved:[,Validators.required],
    inventoryOnHand:[,Validators.required],
    email:['',Validators.required]
  });

  AddStock(){
    const body = {
      productName:this.stockForm.value.productName,
      partNumber:this.stockForm.value.partNumber,
      productLabel:this.stockForm.value.productLabel,
      startingInventory:this.stockForm.value.startingInventory,
      inventoryRecieved:this.stockForm.value.inventoryRecieved,
      inventoryOnHand:this.stockForm.value.inventoryOnHand,
      email:this.stockForm.value.email
    }
    return this.http.post('https://localhost:5001/api/insertStock',body);
  }

  getStocks(){
    return this.http.get('https://localhost:5001/api/stocks');
  }

  getStock(id:number){
    return this.http.get('https://localhost:5001/api/stock/'+id)
  }

  EditStock(id){
    const body = {
      id:parseInt(id),
      productName:this.stockForm.value.productName,
      partNumber:this.stockForm.value.partNumber,
      productLabel:this.stockForm.value.productLabel,
      startingInventory:this.stockForm.value.startingInventory,
      inventoryRecieved:this.stockForm.value.inventoryRecieved,
      inventoryOnHand:this.stockForm.value.inventoryOnHand
    }
    return this.http.put('https://localhost:5001/api/updateStock',body);
  }

  deleteStock(id:number){
    return this.http.delete('https://localhost:5001/api/deleteStock/'+id)
  }

}
