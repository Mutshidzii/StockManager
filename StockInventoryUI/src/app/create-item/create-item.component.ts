import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { StockService } from '../shared/stock.service';

@Component({
  selector: 'app-create-item',
  templateUrl: './create-item.component.html',
  styleUrls: ['./create-item.component.scss']
})
export class CreateItemComponent implements OnInit {

  constructor(public service:StockService,private router:Router) { }

  ngOnInit(): void {
    this.service.stockForm.reset();
  }

  addStock(){
    this.service.AddStock().subscribe(res=>{
      console.log(res);
      this.service.stockForm.reset();
      this.router.navigate([''])
    })
  }

  cancel(){
    this.service.stockForm.reset();
  }
}
