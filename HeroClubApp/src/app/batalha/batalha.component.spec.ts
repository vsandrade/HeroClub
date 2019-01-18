/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { BatalhaComponent } from './batalha.component';

describe('BatalhaComponent', () => {
  let component: BatalhaComponent;
  let fixture: ComponentFixture<BatalhaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BatalhaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BatalhaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
