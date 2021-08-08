import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { KullaniciAddComponent } from './Components/kullanici-add/kullanici-add.component';
import { KullaniciComponent } from './Components/kullanici/kullanici.component';
import { LinkComponent } from './Components/link/link.component';

const routes: Routes = [
  { path:"",pathMatch:"full",component:KullaniciAddComponent},
  //{path: "Link" , component:LinkComponent}
   //{path:"kullanicis/add", component:KullaniciAddComponent},
   {path:"linkolusturma", component:LinkComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
