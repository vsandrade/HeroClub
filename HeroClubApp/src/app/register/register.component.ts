import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Input() valuesFromHome: any;
  @Output() cancelRegister = new EventEmitter();
  model: any = {};

  constructor(private authService: AuthService, private alertifyService: AlertifyService) { }

  ngOnInit() {
  }

  register() {
    this.authService.Register(this.model).subscribe(next => {
      this.alertifyService.success('Registration in Successfully');
    }, error => {
      this.alertifyService.error('Registration to login');
    });
  }

  cancel() {
    this.cancelRegister.emit(false);
    this.alertifyService.message('Cancelled');
  }

}
