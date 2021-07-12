import { Component, OnInit } from '@angular/core';
import { StockService } from '../shared/stock.service';

@Component({
  selector: 'app-barcodes',
  templateUrl: './barcodes.component.html',
  styleUrls: ['./barcodes.component.scss']
})
export class BarcodesComponent implements OnInit {

  stocks:any;
  dataString;
 
  stockArray:any[]=[];

  constructor(private service:StockService) { }

  ngOnInit(): void {
    this.getStocks();
  }

  getStocks(){
    return this.service.getStocks().subscribe(res=>{
       this.stocks = res;
       console.log(this.stocks)
    })
  }

  getStock(stock:any){
    this.dataString = JSON.stringify(stock);
    return this.dataString;
  }
 
}
