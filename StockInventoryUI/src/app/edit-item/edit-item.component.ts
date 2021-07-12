import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { StockService } from '../shared/stock.service';

@Component({
  selector: 'app-edit-item',
  templateUrl: './edit-item.component.html',
  styleUrls: ['./edit-item.component.scss']
})
export class EditItemComponent implements OnInit {

  stock:any;

  constructor(private router:ActivatedRoute,public service:StockService,private _router:Router) { }

  ngOnInit(): void {
    this.getStock()
  }

  editStock(){
    const id = this.router.snapshot.params.id;
    this.service.EditStock(id).subscribe(res=>{
      console.log(res);
      this.service.stockForm.reset();
      this._router.navigate(['']);
    })
  }


  getStock(){
    const id = this.router.snapshot.params.id;
    this.service.getStock(id).subscribe(res=>{
      console.log(res)
      this.stock = res;
      this.service.stockForm.get('productName').setValue(this.stock.productName)
      this.service.stockForm.get('partNumber').setValue(this.stock.partNumber)
      this.service.stockForm.get('productLabel').setValue(this.stock.productLabel)
      this.service.stockForm.get('startingInventory').setValue(this.stock.startingInventory)
      this.service.stockForm.get('inventoryRecieved').setValue(this.stock.inventoryRecieved)
      this.service.stockForm.get('inventoryOnHand').setValue(this.stock.inventoryOnHand)
    })
  }
}
