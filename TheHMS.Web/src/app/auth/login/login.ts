import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  standalone: false,
  templateUrl: './login.html',
  styleUrl: './login.scss'
})
export class Login implements OnInit {
 
  constructor() {
    
    
  }
  ngOnInit(): void {
    
  }












  login() {    // Implement login logic here
    console.log('Login button clicked');
  }
}