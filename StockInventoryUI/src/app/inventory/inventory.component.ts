import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { StockService } from '../shared/stock.service';

@Component({
  selector: 'app-inventory',
  templateUrl: './inventory.component.html',
  styleUrls: ['./inventory.component.scss']
})
export class InventoryComponent implements OnInit {
  
  stocks:any;

  constructor(private router:Router,private service:StockService) { }

  ngOnInit(): void {
    this.getStocks();
  }

  getStocks(){
    return this.service.getStocks().subscribe(res=>{
       this.stocks = res;
       console.log(res)
    })
  }

  deleteStock(id:number){
    this.service.deleteStock(id).subscribe(res=>{
      console.log(res)
      this.getStocks();
      this.router.navigate(['']);
    })
  }
}
