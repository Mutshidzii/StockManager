import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BarcodesComponent } from './barcodes/barcodes.component';
import { CreateItemComponent } from './create-item/create-item.component';
import { EditItemComponent } from './edit-item/edit-item.component';
import { InventoryComponent } from './inventory/inventory.component';
import { ReportsComponent } from './reports/reports.component';

const routes: Routes = [
    {path:'',component:InventoryComponent},
    {path:'inventory',component:InventoryComponent},
    {path:'createItem',component:CreateItemComponent},
    {path:'editItem/:id',component:EditItemComponent},
    {path:'reports',component:ReportsComponent},
    {path:'barcodes',component:BarcodesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
