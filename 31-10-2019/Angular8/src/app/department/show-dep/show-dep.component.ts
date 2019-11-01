import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material';
  

@Component({
  selector: 'app-show-dep',
  templateUrl: './show-dep.component.html',
  styleUrls: ['./show-dep.component.css']
})
export class ShowDepComponent implements OnInit {

  constructor() { }
  
  listData : MatTableDataSource<any>;
  displayedColumns :string[] = ['Options','DepartmentID','DepartmentName']

  ngOnInit() {

    this.refreshDepList();
  }

  refreshDepList(){
    var dummyData = [{DepartmentID:1 , DepartmentName:"It"},
    {DepartmentID:2,DepartmentName:'Finance'}]

    this.listData = new MatTableDataSource(dummyData);
  }

}
